namespace VolunteerBoardMini.Data.DTOs
{
    public class VolunteerInitiativeDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Organizer { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public int RequiredVolunteers { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}