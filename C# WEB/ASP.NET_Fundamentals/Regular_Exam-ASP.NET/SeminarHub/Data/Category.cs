using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SeminarHub.Data.Constants.DataConstants;

namespace SeminarHub.Data
{
    public class Category
    {
        [Comment("Category Identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Name of Category")]
        [Required]
        [MaxLength(CategoryNameMaximumLength)]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Seminar> Seminars { get; set; } = new List<Seminar>();
    }
}