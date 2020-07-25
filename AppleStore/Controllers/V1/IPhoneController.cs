using AppleStore.Repositories;
using AppleStore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppleStore.Controllers.V1
{
    public class IPhoneController : Controller
    {
        private IIPhoneRepository _iPhoneRepository;
        private IIPhoneService _iPhoneService;
        public IPhoneController(IIPhoneRepository iPhoneRepository, IIPhoneService iPhoneService)
        {
            _iPhoneRepository = iPhoneRepository;
            _iPhoneService = iPhoneService;
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

        [Route("/IPhone/AddToCart/{id}/{amount}")]
        public IActionResult AddToCart(int id, int amount) 
        {
            _iPhoneService.AddToCart(id, amount);
            return Redirect("/Product/Index");
        }

        [Route("/IPhone/DeleteFromCart/{id}/{table}")]
        public IActionResult DeleteFromCart(int id, string table)
        {
            _iPhoneService.DeleteFromCart(id, table);
            return Redirect("/Product/Index");
        }
    }
}