using VolunteerBoardMini.Data.Data;
using VolunteerBoardMini.Data.DTOs;
using VolunteerBoardMini.Data.Entities;

namespace VolunteerBoardMini.Data.Services
{
    public class VolunteerInitiativeService
    {
        private readonly VolunteerBoardDbContext _context;

        public VolunteerInitiativeService(VolunteerBoardDbContext context)
        {
            _context = context;
        }

        public List<VolunteerInitiative> GetAll()
        {
            return _context.VolunteerInitiatives.ToList();
        }

        public void Add(VolunteerInitiative initiative)
        {
            _context.VolunteerInitiatives.Add(initiative);
            _context.SaveChanges();
        }
        public List<VolunteerInitiativeDto> GetAllDtos()
        {
            return _context.VolunteerInitiatives
                .Select(i => new VolunteerInitiativeDto
                {
                    Id = i.Id,
                    Name = i.Name,
                    Organizer = i.Organizer,
                    Location = i.Location,
                    RequiredVolunteers = i.RequiredVolunteers,
                    Description = i.Description
                })
                .ToList();
        }
    }
}