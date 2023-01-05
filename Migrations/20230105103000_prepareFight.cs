using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetrpg.Migrations
{
    /// <inheritdoc />
    public partial class prepareFight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Skill_skillsId",
                table: "CharacterSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterSkill",
                table: "CharacterSkill");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSkill_skillsId",
                table: "CharacterSkill");

            migrationBuilder.RenameColumn(
                name: "skillsId",
                table: "CharacterSkill",
                newName: "SkillsId");

            migrationBuilder.AddColumn<int>(
                name: "Defeats",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fights",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vectories",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterSkill",
                table: "CharacterSkill",
                columns: new[] { "SkillsId", "charactersId" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_charactersId",
                table: "CharacterSkill",
                column: "charactersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Skill_SkillsId",
                table: "CharacterSkill",
                column: "SkillsId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Skill_SkillsId",
                table: "CharacterSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterSkill",
                table: "CharacterSkill");

            migrationBuilder.DropIndex(
                name: "IX_CharacterSkill_charactersId",
                table: "CharacterSkill");

            migrationBuilder.DropColumn(
                name: "Defeats",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Fights",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Vectories",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "CharacterSkill",
                newName: "skillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterSkill",
                table: "CharacterSkill",
                columns: new[] { "charactersId", "skillsId" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_skillsId",
                table: "CharacterSkill",
                column: "skillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Skill_skillsId",
                table: "CharacterSkill",
                column: "skillsId",
                principalTable: "Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
