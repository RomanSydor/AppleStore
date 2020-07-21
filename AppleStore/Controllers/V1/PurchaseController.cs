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
        public ActionResult Create([Bind("Id,FirstName,LastName,PhoneNumber,Email,Date")]Purchase purchase)
        {
            if (ModelState.IsValid)
            {
                var pur = _service.Create();
                pur.FirstName = purchase.FirstName;
                pur.LastName = purchase.LastName;
                pur.PhoneNumber = purchase.PhoneNumber;
                pur.Email = purchase.Email;
                _repository.Create(pur);
                return RedirectToAction("Index", "Home"); // TODO purchase confirm
            } 
            return View(_service.Create());
        }
    }
}
