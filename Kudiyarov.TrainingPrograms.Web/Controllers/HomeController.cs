using Kudiyarov.TrainingPrograms.Core.Bll.Interfaces;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Enums;
using Kudiyarov.TrainingPrograms.Core.Common.Entities.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITrainingProgramLogic _logic;

        public HomeController(ITrainingProgramLogic logic)
        {
            _logic = logic;
        }

        public IActionResult Index()
        {
            var result = _logic.Get();
            return View(result);
        }

        public IActionResult Program(ProgramType type)
        {
            var result = _logic.Get(type);
            return View(result);
        }

        public IActionResult Session(SessionRequest request)
        {
            var result = _logic.Get(request);
            return View(result);
        }
    }
}