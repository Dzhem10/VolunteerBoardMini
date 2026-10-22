using Microsoft.AspNetCore.Mvc;
using VolunteerBoardMini.Library.Models;

namespace VolunteerBoardMini.Web.Controllers
{
    public class VolunteerInitiativesController : Controller
    {
        public IActionResult Index()
        {
            var initiatives = new List<VolunteerInitiative>
            {
                new VolunteerInitiative
                {
                    Id = 1,
                    Name = "Почистване на парк",
                    Organizer = "Еко организация",
                    Location = "Перник",
                    RequiredVolunteers = 10,
                    Description = "Почистване и облагородяване на градския парк."
                },
                new VolunteerInitiative
                {
                    Id = 2,
                    Name = "Помощ за възрастни хора",
                    Organizer = "Доброволчески център",
                    Location = "София",
                    RequiredVolunteers = 5,
                    Description = "Помощ при ежедневни задачи."
                }
            };

            return View(initiatives);
        }
    }
}
