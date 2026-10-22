using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolunteerBoardMini.Library.Models
{
    public class VolunteerInitiative
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Organizer { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int RequiredVolunteers { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
