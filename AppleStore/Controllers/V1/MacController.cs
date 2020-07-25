using AppleStore.Repositories;
using AppleStore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class MacController : Controller
    {
        private IMacRepository _macRepository;
        private IMacService _macService;

        public MacController(IMacRepository macRepository, IMacService macService)
        {
            _macRepository = macRepository;
            _macService = macService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var macs = await _macRepository.GetMacsAsync();
            return View(macs);
        }

        [HttpGet]
        [Route("/Mac/Models/{type}")]
        public async Task<IActionResult> Models([FromRoute]string type)
        {
            var macs = await _macRepository.GetMacByModelAsync(type);
            return View(macs);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) 
        {
            var mac = await _macRepository.GetMacByIdAsync(id);
            
            if (mac == null) 
            {
                return NotFound();
            }
            return View(mac);
        }

        [Route("/Mac/AddToCart/{id}/{amount}")]
        public IActionResult AddToCart(int id, int amount)
        {
            _macService.AddToCart(id, amount);
            return Redirect("/Product/Index");
        }

        [Route("/Mac/DeleteFromCart/{id}/{table}")]
        public IActionResult DeleteFromCart(int id, string table)
        {
            _macService.DeleteFromCart(id, table);
            return Redirect("/Product/Index");
        }
    }
}
