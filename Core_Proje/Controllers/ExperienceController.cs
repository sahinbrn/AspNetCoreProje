using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize]
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experiences experiences)
        {
            experienceManager.TAdd(experiences);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value = experienceManager.TGetByID(id);
            if (value == null)
            {
                return NotFound();
            }

            experienceManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
		public IActionResult EditExperience(int id)
		{
			var values = experienceManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditExperience(Experiences experiences)
		{
			experienceManager.TUpdate(experiences);
			return RedirectToAction("Index");
		}

	}
}
