using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeminarHub.Data;
using SeminarHub.Data.Constants;
using SeminarHub.Models;
using System.Globalization;
using System.Security.Claims;
using static SeminarHub.Data.Constants.DataConstants;

namespace SeminarHub.Controllers
{
    [Authorize]
    public class SeminarController : Controller
    {
        private readonly SeminarHubDbContext dbContext;

        public SeminarController(SeminarHubDbContext context)
        {
            dbContext = context;
        }

        public async Task<IActionResult> All()
        {
            var seminars = await dbContext.Seminars
                .AsNoTracking()
                .Select(sp => new SeminarInfoViewModel(
                    sp.Id,
                    sp.Topic,
                    sp.Lecturer,
                    sp.Category.Name,
                    sp.DateAndTime,
                    sp.Organizer.UserName
                ))
                .ToListAsync();

            return View(seminars);
        }

        [HttpGet]
        public async Task<IActionResult> Joined()
        {
            string userId = GetUserId();

            var model = await dbContext.SeminarParticipants
                .Where(sp => sp.ParticipantId == userId)
                .AsNoTracking()
                .Select(sp => new SeminarInfoViewModel(
                    sp.SeminarId,
                    sp.Seminar.Topic,
                    sp.Seminar.Lecturer,
                    sp.Seminar.Category.Name,
                    sp.Seminar.DateAndTime,
                    sp.Seminar.Organizer.UserName
                ))
                .ToListAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {
            var seminar = await dbContext.Seminars
                .Where(s => s.Id == id)
                .Include(sp => sp.SeminarsParticipants)
                .FirstOrDefaultAsync();

            if (seminar == null)
            {
                return BadRequest();
            }

            string userId = GetUserId();

            if (seminar.SeminarsParticipants.All(sp => sp.ParticipantId != userId))
            {
                seminar.SeminarsParticipants.Add(new SeminarParticipant()
                {
                    SeminarId = seminar.Id,
                    ParticipantId = userId

                });

                await dbContext.SaveChangesAsync();
            }
            else
            {
                return RedirectToAction(nameof(All));
            }

            return RedirectToAction(nameof(Joined));
        }

        public async Task<IActionResult> Leave(int id)
        {
            var seminars = await dbContext.Seminars
                .Where(s => s.Id == id)
                .Include(sp => sp.SeminarsParticipants)
                .FirstOrDefaultAsync();

            if (seminars == null)
            {
                return BadRequest();
            }

            string userId = GetUserId();

            var seminarPart = seminars.SeminarsParticipants
                .FirstOrDefault(sp => sp.ParticipantId == userId);

            if (seminarPart == null)
            {
                return BadRequest();
            }

            seminars.SeminarsParticipants.Remove(seminarPart);

            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Joined));
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new SeminarFormViewModel();
            model.Categories = await GetCategory();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(SeminarFormViewModel model)
        {
            DateTime seminarDate = DateTime.Now;

            if (!DateTime.TryParseExact(
                    model.DateAndTime,
                    DateTimeFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out seminarDate))
            {
                ModelState
                    .AddModelError(nameof(model.DateAndTime), $"Invalid date! Format must be: {DateTimeFormat}");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategory();

                return View(model);
            }

            var entity = new Seminar()
            {
                Topic = model.Topic,
                Lecturer = model.Lecturer,
                Details = model.Details,
                DateAndTime = seminarDate,
                Duration = model.Duration,
                OrganizerId = GetUserId(),
                CategoryId = model.CategoryId
            };
            //if (entity.Details.StartsWith("http"))
            //{
            //    Url.Link(entity.Details.);
            //}
            await dbContext.Seminars.AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var seminars = await dbContext.Seminars
                .FindAsync(id);

            if (seminars == null)
            {
                return BadRequest("You are not the seminar creator!\r\nYou can't edit it!");
            }

            if (seminars.OrganizerId != GetUserId())
            {
                return Unauthorized("You are not the seminar creator!\r\nYou can't edit it!");
            }

            var model = new SeminarFormViewModel()
            {
                Topic = seminars.Topic,
                Lecturer = seminars.Lecturer,
                Details = seminars.Details,
                DateAndTime = seminars.DateAndTime.ToString(DateTimeFormat),
                Duration = seminars.Duration,
                CategoryId = seminars.CategoryId
            };

            model.Categories = await GetCategory();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SeminarFormViewModel model, int id)
        {
            var seminars = await dbContext.Seminars
                .FindAsync(id);

            if (seminars == null)
            {
                return BadRequest("You are not the seminar creator!\r\nYou can't edit it!");
            }

            if (seminars.OrganizerId != GetUserId())
            {
                return Unauthorized("You are not the seminar creator!\r\nYou can't edit it!");
            }

            DateTime seminarDate = DateTime.Now;

            if (!DateTime.TryParseExact(
                    model.DateAndTime,
                    DateTimeFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out seminarDate))
            {
                ModelState
                    .AddModelError(nameof(model.DateAndTime), $"Invalid date! Format must be: {DateTimeFormat}");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategory();

                return View(model);
            }

            seminars.Topic = model.Topic;
            seminars.Lecturer = model.Lecturer;
            seminars.Details = model.Details;
            seminars.DateAndTime = seminarDate;
            seminars.Duration = model.Duration;
            seminars.CategoryId = model.CategoryId;

            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> Details(int id)
        {
            var seminar = await dbContext.Seminars
                .Where(s => s.Id == id)
                .AsNoTracking()
                .Select(sp => new SeminarDetailsViewModel()
                {
                    Id = sp.Id,
                    Topic = sp.Topic,
                    DateAndTime = sp.DateAndTime.ToString(DateTimeFormat),
                    Duration = sp.Duration,
                    Lecturer = sp.Lecturer,
                    Category = sp.Category.Name,
                    Details = sp.Details,
                    Organizer = sp.Organizer.UserName
                })
                .FirstOrDefaultAsync();

            if (seminar == null)
            {
                return BadRequest();
            }

            return View(seminar);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var seminarToDelete = await dbContext.Seminars
                .Where(s => s.Id == id)
                .AsNoTracking()
                .Select(sp => new SeminarDeleteViewModel()
                {
                    Id = sp.Id,
                    Topic = sp.Topic,
                    DateAndTime = sp.DateAndTime,
                    OrganizerId = sp.OrganizerId
                })
                .FirstOrDefaultAsync();

            if (seminarToDelete == null)
            {
                return BadRequest();
            }
            if (seminarToDelete.OrganizerId != GetUserId())
            {
                return Unauthorized("You are not the seminar creator!\r\nYou can't delete it!");
            }
            return View(seminarToDelete);

        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var seminarToDelete = await dbContext.Seminars.FindAsync(id);

            if (seminarToDelete == null)
            {
                return BadRequest("You are not the seminar creator!\r\nYou can't delete it!");
            }

            if (seminarToDelete.OrganizerId != GetUserId())
            {
                return Unauthorized("You are not the seminar creator!\r\nYou can't delete it!");
            }
            dbContext.Seminars.Remove(seminarToDelete);
            await dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(All)); ;
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
        private async Task<IEnumerable<CategoryViewModel>> GetCategory()
        {
            return await dbContext.Categories
                .AsNoTracking()
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }
    }
}
