using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.SocialMedya
{
    public class SocialMedyaList : ViewComponent
    {
		SocialMedyaManager socialMedyaManager = new SocialMedyaManager(new EfSocialMedyaDal());
		public IViewComponentResult Invoke()
        {
            var values = socialMedyaManager.TGetList();
            return View(values);
        }
    }
}
