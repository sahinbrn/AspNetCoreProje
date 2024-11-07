using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize]
    public class ContactSubplaceController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = contactManager.TGetByID(1);
            return View(values);

        }

        [HttpPost]
        public IActionResult Index(Contacts contacts)
        {
            contactManager.TUpdate(contacts);
            return RedirectToAction("Index", "Default");
        }
    }
}
