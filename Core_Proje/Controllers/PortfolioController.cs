using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccsessLayer.EntityFramework;
using EntityLater.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize]
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolios portfolios)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results =validations.Validate(portfolios);
            if(results.IsValid)
            {
                portfolioManager.TAdd(portfolios);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolios portfolios)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results= validations.Validate(portfolios);
            if(results.IsValid) { 
            portfolioManager.TUpdate(portfolios);
            return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors) {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                        }
            }
            return View();
        }

    }
}
