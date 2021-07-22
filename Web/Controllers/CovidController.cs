using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidController: ControllerBase
    {
        private readonly ICovidSummaryRepository _covidRepository;
        public CovidController(ICovidSummaryRepository covidRepository)
        {
            _covidRepository = covidRepository;       
        }
        [HttpGet]
        public async Task<IActionResult> GetCovidSummary()
        {
            var result = await _covidRepository.GetSummary();
            return Ok(result);
        }
    }
}
