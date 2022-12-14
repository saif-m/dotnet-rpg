using dotnet_rpg.Dtos.Fight;

namespace dotnet_rpg.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResaultDto>> WeaponAttack(WeaponAttackDto request);

        Task<ServiceResponse<AttackResaultDto>> SkillAttack(SkillAttackDto request);

        Task<ServiceResponse<FightResaultDto>> Fight(FightRequestDto request);
    }
}