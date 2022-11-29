namespace dotnet_rpg.Services
{
    public interface ICharacterService
    {
        Task<List<Character>> AddCharacter(Character newCharacter);
        
         Task<List<Character>> GetAllCharacters();

         Task<Character> GetCharacterById(int id);
    }
}