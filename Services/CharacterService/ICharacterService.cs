using dotnet_rpg.Dtos.Characters;

namespace dotnet_rpg.Services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateedCharacter);
         
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}