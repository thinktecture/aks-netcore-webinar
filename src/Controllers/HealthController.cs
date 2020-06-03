using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Thinktecture.AKS.Webinar.Controllers
{

    [Route("health")]
    public class HealthController : ControllerBase
    {

        [HttpGet]
        [Route("ready")]
        public async Task<IActionResult> IsReadyAsync()
        {
            return await Task.FromResult(Ok());
        }

        [HttpGet]
        [Route("healthy")]
        public async Task<IActionResult> IsHealthyAsync()
        {
            return await Task.FromResult(Ok());
        }
    }

}