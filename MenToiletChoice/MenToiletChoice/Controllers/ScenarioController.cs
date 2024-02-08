using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenToiletChoice.Controllers
{
    [ApiController]
    public class ScenarioController : ControllerBase
    {

      [HttpGet("scenarios")]
      public IActionResult Get()
        {
            var scenarios = ScenarioService.GetConfig();
            //
            return Ok(scenarios);
        }
    }
}
