using AppleStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class MacController : Controller
    {
        private IMacRepository _macRepository;

        public MacController(IMacRepository macRepository)
        {
            _macRepository = macRepository;
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
    }
}
