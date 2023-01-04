using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Data;
using dotnet_rpg.Dtos.Fight;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Services.FightService
{
    public class FightService : IFightService
    {
        private readonly DataContext _context;

        public FightService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<AttackResaultDto>> SkillAttack(SkillAttackDto request) {
            var response = new ServiceResponse<AttackResaultDto>();
            try {

                var attacker = await _context.Characters
                                .Include(c => c.Skills)
                                .FirstOrDefaultAsync(c => c.Id == request.AttackerId);
                var opponent = await _context.Characters
                                .FirstOrDefaultAsync(c => c.Id == request.OpponentId);

                var skill = attacker.Skills.FirstOrDefault(s => s.Id == request.SkillId);

                if (skill == null) {
                    response.Success = false;
                    response.Message = $"{attacker.Name} dosn't know that skill.";
                    return response;
                }

                int damage = skill.Damage + (new Random().Next(attacker.Intelligance));

                damage -= (new Random().Next(opponent.Defence));

                if (damage > 0)
                    opponent.HitPoints -= damage;

                if (opponent.HitPoints <= 0) {
                    response.Message = $"{opponent.Name} has been defeated!";
                }

                await _context.SaveChangesAsync();

                response.Data = new AttackResaultDto {
                    Attacker = attacker.Name,
                    Opponent = opponent.Name,
                    AttackerHp = attacker.HitPoints,
                    OpponentHp = opponent.HitPoints,
                    Damage = damage
                };


            } catch(Exception ex) {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<ServiceResponse<AttackResaultDto>> WeaponAttack(WeaponAttackDto request) {
            var response = new ServiceResponse<AttackResaultDto>();
            try {

                var attacker = await _context.Characters
                                .Include(c => c.Weapon)
                                .FirstOrDefaultAsync(c => c.Id == request.AttackerId);
                var opponent = await _context.Characters
                                .FirstOrDefaultAsync(c => c.Id == request.OpponentId);

                int damage = attacker.Weapon.Damage + (new Random().Next(attacker.Strength));

                damage -= (new Random().Next(opponent.Defence));

                if (damage > 0)
                    opponent.HitPoints -= damage;

                if (opponent.HitPoints <= 0) {
                    response.Message = $"{opponent.Name} has been defeated!";
                }

                await _context.SaveChangesAsync();

                response.Data = new AttackResaultDto {
                    Attacker = attacker.Name,
                    Opponent = opponent.Name,
                    AttackerHp = attacker.HitPoints,
                    OpponentHp = opponent.HitPoints,
                    Damage = damage
                };


            } catch(Exception ex) {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}