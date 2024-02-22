using System.ComponentModel.DataAnnotations;
using static SeminarHub.Models.ErrorMessages.ErrorMessage;
using static SeminarHub.Data.Constants.DataConstants;
namespace SeminarHub.Models
{
    public class SeminarFormViewModel
    {
        [Required(ErrorMessage = IsRequireErrorMessage)]
        [StringLength(TopicNameMaximumLength,
            MinimumLength = TopicNameMinimumLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Topic { get; set; } = string.Empty;


        [Required(ErrorMessage = IsRequireErrorMessage)]
        [StringLength(LecturerNameMaximumLength,
            MinimumLength = LecturerNameMinimumLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Lecturer { get; set; } = string.Empty;


        [Required(ErrorMessage = IsRequireErrorMessage)]
        [StringLength(DetailsMaximumLength,
            MinimumLength = DetailsMinimumLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Details { get; set; } = string.Empty;


        [Required(ErrorMessage = IsRequireErrorMessage)]
        public string DateAndTime { get; set; } = string.Empty;


        [Required(ErrorMessage = IsRequireErrorMessage)]
        [Range(DurationMinimumValue, DurationMaximumValue, ErrorMessage = DurationValueErrorMessage)]
        public int Duration { get; set; }

        [Required(ErrorMessage = IsRequireErrorMessage)]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();

    }
}