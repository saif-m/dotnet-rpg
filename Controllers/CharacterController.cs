using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CharacterController: ControllerBase{
        private static Character Knight = new Character();

        [HttpGet]
        public ActionResult<Character> get() {
            return Ok(Knight);
        }
    }
}