using AppleStore.Repositories;
using AppleStore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class AirPodsController : Controller
    {
        private IAirPodsRepository _airPodsRepository;
        private IAirPodsService _airPodsService;

        public AirPodsController(IAirPodsRepository airPodsRepository, IAirPodsService airPodsService)
        {
            _airPodsRepository = airPodsRepository;
            _airPodsService = airPodsService;
        }

        [HttpGet]
        public async Task<IActionResult> Models()
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

        [Route("/AirPods/AddToCart/{id}/{amount}")]
        public IActionResult AddToCart(int id, int amount)
        {
            _airPodsService.AddToCart(id, amount);
            return Redirect("/Product/Index");
        }

        [Route("/AirPods/DeleteFromCart/{id}/{table}")]
        public IActionResult DeleteFromCart(int id, string table)
        {
            _airPodsService.DeleteFromCart(id, table);
            return Redirect("/Product/Index");
        }
    }
}