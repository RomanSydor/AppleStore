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
    }
}
