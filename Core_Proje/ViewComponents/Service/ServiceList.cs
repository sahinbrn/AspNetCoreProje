using System;
using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
	public IViewComponentResult Invoke()
	{
		var values = serviceManager.TGetList();

		return View(values);
	}
}
}
