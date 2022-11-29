using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CharacterController: ControllerBase{
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id=1, Name="Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> get() {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Character>> GetSingle(int id) {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}