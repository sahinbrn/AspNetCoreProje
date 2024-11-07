using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Core_Proje.Controllers
{
    [AllowAnonymous]


    public class DefaultController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
    
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        //public PartialViewResult SendMessage(Message p)
        //{
        //	MessageManager messageManager = new MessageManager(new EfMessageDal());

        //	p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //	p.Status = true;
        //	messageManager.TAdd(p);
        //	return PartialView();
        //}
        [HttpPost]
        [HttpPost]
        public IActionResult SendMessage(Message p)
        {
            if (ModelState.IsValid)
            {
                MessageManager messageManager = new MessageManager(new EfMessageDal());
                p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                p.Status = true;
                messageManager.TAdd(p);

                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}
