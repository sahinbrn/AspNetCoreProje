using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace Core_Proje.Controllers
{
    [Authorize]
    public class FeatureController : Controller
	{
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        [HttpGet]
		public IActionResult Index()
		{
            var values = featureManager.TGetByID(1 );
            return View(values);

		}
        
        [HttpPost]
        public IActionResult Index(Features features)
        {
            featureManager.TUpdate(features);
            return RedirectToAction("Index","Default");
        }
    }
}
