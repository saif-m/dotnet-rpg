namespace dotnet_rpg.Services
{
    public interface ICharacterService
    {
        List<Character> AddCharacter(Character newCharacter);
        
         List<Character> GetAllCharacters();

         Character GetCharacterById(int id);
    }
}