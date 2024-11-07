using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutManager.TGetByID(1);
            return View(values);

        }

        [HttpPost]
        public IActionResult Index(Abouts abouts)
        {
            aboutManager.TUpdate(abouts);
            return RedirectToAction("Index", "Default");
        }
    }
}
