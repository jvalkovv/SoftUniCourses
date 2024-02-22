using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SeminarHub.Data.Constants.DataConstants;
namespace SeminarHub.Data
{
    public class Seminar
    {
        [Comment("Seminar Identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of Topic")]
        [Required]
        [MaxLength(TopicNameMaximumLength)]
        public string Topic { get; set; } = string.Empty;

        [Comment("Name of Lecturer")]
        [Required]
        [MaxLength(LecturerNameMaximumLength)]
        public string Lecturer { get; set; } = string.Empty;

        [Comment("Details of Seminar")]
        [Required]
        [MaxLength(DetailsMaximumLength)]
        public string Details { get; set; } = string.Empty;

        [Comment("Organizer identifier")]
        [Required]
        public string OrganizerId { get; set; } = string.Empty;


        [Comment("Organizer name")]
        [Required]
        [ForeignKey(nameof(OrganizerId))]
        public IdentityUser Organizer { get; set; } = null!;

        [Required]
        public DateTime DateAndTime { get; set; }


        [Comment("Duration of the seminar")]
        [MaxLength(DurationMaximumValue)]
        public int Duration { get; set; }

        [Comment("Category identifier")]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        [Comment("Category name")]
        public Category Category { get; set; } = null!;

        public IList<SeminarParticipant> SeminarsParticipants { get; set; } = new List<SeminarParticipant>();
    }
}
