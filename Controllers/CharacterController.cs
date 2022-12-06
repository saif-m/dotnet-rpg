using dotnet_rpg.Dtos.Characters;
using dotnet_rpg.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CharacterController : ControllerBase
    {
        // import the Service and the service interface
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            this._characterService = characterService;

        }
        // end importing the Service and the service interface

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> get()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            return Ok(_characterService.UpdateCharacter(updatedCharacter));
        }
    }
}