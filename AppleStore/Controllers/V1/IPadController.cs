using AppleStore.Repositories;
using AppleStore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class IPadController : Controller
    {
        private IIPadRepository _iPadRepository;
        private IIPadService _iPadService;

        public IPadController(IIPadRepository iPadRepository, IIPadService iPadService)
        {
            _iPadRepository = iPadRepository;
            _iPadService = iPadService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var iPads = await _iPadRepository.GetIPadsAsync();
            return View(iPads);
        }

        [HttpGet]
        [Route("/IPad/Models/{type}")]
        public async Task<IActionResult> Models([FromRoute]string type) 
        {
            var iPads = await _iPadRepository.GetIPadByModelAsync(type);
            return View(iPads);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) 
        {
            var iPad = await _iPadRepository.GetIPadByIdAsync(id);
            if (iPad == null) 
            {
                return NotFound();
            }
            return View(iPad);
        }

        [HttpGet]
        [Route("/IPad/Details/{model}/{type}/{color}/{memory}")]
        public IActionResult Details([FromRoute]string color, [FromRoute]string memory, [FromRoute]string model, [FromRoute]string type)
        {
            if (type == "Wi-Fi-pl-LTE") 
            {
                type = "Wi-Fi+LTE";
            }
            var iPad = _iPadRepository.GetIPadByColorAndMemory(color, memory, model, type);

            if (iPad == null)
            {
                return NotFound();
            }

            return View(iPad);
        }

        [Route("/IPad/AddToCart/{id}/{amount}")]
        public IActionResult AddToCart(int id, int amount)
        {
            _iPadService.AddToCart(id, amount);
            return Redirect("/Product/Index");
        }

        [Route("/IPad/DeleteFromCart/{id}/{table}")]
        public IActionResult DeleteFromCart(int id, string table)
        {
            _iPadService.DeleteFromCart(id, table);
            return Redirect("/Product/Index");
        }
    }
}
