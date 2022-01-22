using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers {
    [Route("api/c/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase {
        public AdminController() {
            
        }

        [HttpPost]
        public ActionResult TestInboundConnection () {
            Console.WriteLine("--> Inbound POST # Command Service");

            return Ok("Inbound test ok");
        }
    }
}