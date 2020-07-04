using AppleStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class AirPodsController : Controller
    {
        private IAirPodsRepository _airPodsRepository;

        public AirPodsController(IAirPodsRepository airPodsRepository)
        {
            _airPodsRepository = airPodsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var airPodses = await _airPodsRepository.GetAirPodsesAsync();
            return View(airPodses);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var airPods = await _airPodsRepository.GetAirPodsByIdAsync(id);
            return View(airPods);
        }
    }
}