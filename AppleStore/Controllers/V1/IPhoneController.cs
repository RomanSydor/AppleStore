using AppleStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class IPhoneController : Controller
    {
        private IIPhoneRepository _iPhoneRepository;
        public IPhoneController(IIPhoneRepository iPhoneRepository)
        {
            _iPhoneRepository = iPhoneRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var iPhones = await _iPhoneRepository.GetIPhonesAsync();
            return View(iPhones);
        }

        [HttpGet]
        [Route("/IPhone/Models/{model}")]
        public async Task<IActionResult> Models([FromRoute]string model) 
        {
            var iPhones = await _iPhoneRepository.GetIPhoneByModelAsync(model);
            return View(iPhones);
        }

        [HttpGet]
        [Route("/IPhone/Details/{id}")]
        public async Task<IActionResult> Details([FromRoute]int id)
        {
            var iPhone = await _iPhoneRepository.GetIPhoneByIdAsync(id);

            if (iPhone == null)
            {
                return NotFound();
            }

            return View(iPhone);
        }

        [HttpGet]
        [Route("/IPhone/Details/{model}/{color}/{memory}")]
        public IActionResult Details([FromRoute]string color, [FromRoute]string memory, [FromRoute]string model)
        {
            var iPhone = _iPhoneRepository.GetIPhoneByColorAndMemoryAsync(color, memory, model);

            if (iPhone == null)
            {
                return NotFound();
            }

            return View(iPhone);
        }
    }
}