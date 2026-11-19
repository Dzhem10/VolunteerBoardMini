using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace VolunteerBoardMini.Data.Entities
{
    public class Volunteer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;
        public ICollection<VolunteerRegistration> Registrations { get; set; } = new List<VolunteerRegistration>();
    }
}