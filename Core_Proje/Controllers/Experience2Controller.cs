using Microsoft.AspNetCore.Mvc;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace Core_Proje.Controllers
{
    [Authorize]
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }

        [HttpPost]
        public IActionResult AddExperience(Experiences experiences)
        {
            experienceManager.TAdd(experiences);
            var values = JsonConvert.SerializeObject(experiences);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceID)
        {
            var v = experienceManager.TGetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetByID(id);
            experienceManager.TDelete(v);
            return NoContent();
        }
    }
}
