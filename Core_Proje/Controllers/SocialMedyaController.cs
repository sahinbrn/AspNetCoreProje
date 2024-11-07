using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;

namespace Core_Proje.Controllers
{
    [Authorize]
    public class SocialMedyaController : Controller
    {
        SocialMedyaManager socialMedyaManager = new SocialMedyaManager(new EfSocialMedyaDal());
        public IActionResult Index()
        {
            var values = socialMedyaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedya() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedya(SocialMedya socialMedya)
        {
            socialMedya.Status = true;
            socialMedyaManager.TAdd(socialMedya);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedya(int id)
        {
          var values= socialMedyaManager.TGetByID(id);
            socialMedyaManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSocialMedya(int id)
        {
            var values=socialMedyaManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSocialMedya(SocialMedya socialMedya)
        {
            socialMedyaManager.TUpdate(socialMedya);
            return RedirectToAction("Index");
        }
    }
}
