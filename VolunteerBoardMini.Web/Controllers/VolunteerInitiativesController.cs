using Microsoft.AspNetCore.Mvc;
using VolunteerBoardMini.Data.Entities;
using VolunteerBoardMini.Data.Services;
using VolunteerBoardMini.Data.DTOs;

namespace VolunteerBoardMini.Web.Controllers
{
    public class VolunteerInitiativesController : Controller
    {
        private readonly VolunteerInitiativeService _service;

        public VolunteerInitiativesController(VolunteerInitiativeService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var initiatives = _service.GetAllDtos();
            return View(initiatives);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VolunteerInitiative initiative)
        {
            if (ModelState.IsValid)
            {
                _service.Add(initiative);
                return RedirectToAction(nameof(Index));
            }

            return View(initiative);
        }
    }
}