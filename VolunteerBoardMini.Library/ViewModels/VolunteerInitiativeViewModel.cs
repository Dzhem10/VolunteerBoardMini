using System.ComponentModel.DataAnnotations;

namespace VolunteerBoardMini.Web.ViewModels
{
    public class VolunteerInitiativeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Organizer { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Range(1, 1000)]
        public int RequiredVolunteers { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}