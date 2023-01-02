using dotnet_rpg.Dtos.Weapon;
using dotnet_rpg.Dtos.Skill;

namespace dotnet_rpg.Dtos.Characters
{
    public class GetCharacterDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defence { get; set; } = 10;

        public int Intelligance { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;

        public GetWeaponDto Weapon { get; set; }

        public List<GetSkillDto> Skills { get; set; }
    }
}