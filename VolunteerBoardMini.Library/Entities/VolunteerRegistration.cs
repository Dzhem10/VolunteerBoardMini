namespace VolunteerBoardMini.Data.Entities
{
    public class VolunteerRegistration
    {
        public int VolunteerId { get; set; }

        public Volunteer Volunteer { get; set; } = null!;

        public int VolunteerInitiativeId { get; set; }

        public VolunteerInitiative VolunteerInitiative { get; set; } = null!;
    }
}