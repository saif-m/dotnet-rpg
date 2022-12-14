namespace dotnet_rpg.Dtos.Characters
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defence { get; set; } = 10;

        public int Intelligance { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}