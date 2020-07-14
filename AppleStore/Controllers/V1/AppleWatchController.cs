using AppleStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class AppleWatchController : Controller
    {
        private IAppleWatchRepository _appleWatchRepository;

        public AppleWatchController(IAppleWatchRepository appleWatchRepository)
        {
            _appleWatchRepository = appleWatchRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index() 
        {
            var watches = await _appleWatchRepository.GetAppleWatchesAsync();
            return View(watches);
        }

        [HttpGet]
        [Route("/AppleWatch/Models/{model}")]
        public async Task<IActionResult> Models([FromRoute]string model)
        {
            var watches = await _appleWatchRepository.GetAppleWatchByModelAsync(model);
            return View(watches);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) 
        {
            var watch = await _appleWatchRepository.GetAppleWatchByIdAsync(id);
            return View(watch);
        }

        [HttpGet]
        [Route("/AppleWatch/Details/{model}/{size}/{color}/{celluar}")]
        public IActionResult Details([FromRoute]string color, [FromRoute]int size, [FromRoute]string model, [FromRoute]string celluar)
        {
            var watch = _appleWatchRepository.GetWatchByColorAndSize(size, color, model, celluar);

            if (watch == null)
            {
                return NotFound();
            }

            return View(watch);
        }
    }
}
