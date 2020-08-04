using AppleStore.Models;
using AppleStore.Repositories;
using AppleStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppleStore.Controllers.V1
{
    public class PurchaseController : Controller
    {

        private IPurchaseRepository _repository;
        private IPurchaseService _service;

        public PurchaseController(IPurchaseRepository repository, IPurchaseService service)
        {
            _repository = repository;
            _service = service;
        }

        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,FirstName,LastName,PhoneNumber,Email,Date,PromoCode")]Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                _service.CountPrice(purchase.PromoCode);
                var pur = _service.Create();
                pur.FirstName = purchase.FirstName;
                pur.LastName = purchase.LastName;
                pur.PhoneNumber = purchase.PhoneNumber;
                pur.Email = purchase.Email;
                _repository.Create(pur);
                return RedirectToAction("Details", "Purchase", new Purchase { Id = pur.Id });
            } 
            return View(_service.Create());
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var pur = _repository.Details(id);

            if (pur == null)
            {
                return NotFound();
            }
            return View(pur);
        }

        public IActionResult Delete(int id) 
        {
            _repository.Delete(id);
            return RedirectToAction("Create", "Purchase");
        }

        public IActionResult AfterPurchase() 
        {
            _service.ClearList();
            return View();
        }
    }
}
