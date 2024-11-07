using BusinessLayer.Concrete;
using Core_Proje.ViewComponents.Skill;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize]
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values =skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skills skills)
        {
            skillManager.TAdd(skills);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
			return RedirectToAction("Index");
		}
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
			var values =skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skills skills)
        {
            skillManager.TUpdate(skills);
            return RedirectToAction("Index");
        }
        
    }
}
