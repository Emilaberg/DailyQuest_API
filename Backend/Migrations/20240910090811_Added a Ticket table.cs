﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedaTickettable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateLastSent = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                });

            migrationBuilder.CreateTable(
                name: "MetaTags",
                columns: table => new
                {
                    MetaTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaTags", x => x.MetaTagId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionMetaTags",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    MetaTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionMetaTags", x => new { x.QuestionId, x.MetaTagId });
                    table.ForeignKey(
                        name: "FK_QuestionMetaTags_MetaTags_MetaTagId",
                        column: x => x.MetaTagId,
                        principalTable: "MetaTags",
                        principalColumn: "MetaTagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionMetaTags_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizQuestions",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestions", x => new { x.QuizId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_QuizQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuizQuestions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "DateLastSent", "Email" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7187), "Maxtharn@gmail.com" },
                    { 2, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7228), "Nckandero@gmail.com" },
                    { 3, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7229), "emil.aberg@live.com" },
                    { 4, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7231), "e.johannesnilsson@gmail.com" },
                    { 5, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7232), "emmzaa1337@gmail.com" },
                    { 6, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7234), "Din@Son.lol" },
                    { 7, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7235), "Din@Kusin.lol" },
                    { 8, new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7236), "oscar.sommerfors@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "MetaTags",
                columns: new[] { "MetaTagId", "TagName" },
                values: new object[,]
                {
                    { 1, "World of Warcraft" },
                    { 2, "League of Legends" },
                    { 3, "Pokemon" },
                    { 4, "Counter-Strike" },
                    { 5, "Super Mario" },
                    { 6, "The Legend of Zelda" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Image", "Question" },
                values: new object[,]
                {
                    { 1, null, "What is the capital city of the Horde?" },
                    { 2, null, "Who is the Warchief after Thrall?" },
                    { 3, null, "What class was introduced in 'The Burning Crusade'?" },
                    { 4, null, "Which expansion featured the continent of Pandaria?" },
                    { 5, null, "What is the name of the Lich King's sword?" },
                    { 6, null, "Who guards the Caverns of Time?" },
                    { 7, null, "Which race can choose to be either Horde or Alliance?" },
                    { 8, null, "What material is needed to craft a Thunderfury?" },
                    { 9, null, "Who did players fight in the Firelands raid?" },
                    { 10, null, "Which dragon aspect is responsible for the Emerald Dream?" },
                    { 11, null, "What was the first battleground introduced in WoW?" },
                    { 12, null, "Which raid includes the fight against Illidan?" },
                    { 13, null, "What profession deals with glyphs?" },
                    { 14, null, "Where is the Dark Portal located?" },
                    { 15, null, "What is the home planet of the Draenei?" },
                    { 16, null, "Which champion has an ability called 'Cataclysm'?" },
                    { 17, null, "What is the main currency in League of Legends?" },
                    { 18, null, "Which role typically goes to the mid lane?" },
                    { 19, null, "What is the maximum cooldown reduction achievable?" },
                    { 20, null, "Who is known as the Grandmaster at Arms?" },
                    { 21, null, "Which champion is a void creature?" },
                    { 22, null, "What champion has a pet named Valor?" },
                    { 23, null, "Which champion can steal abilities?" },
                    { 24, null, "What item increases attack speed and critical strike chance?" },
                    { 25, null, "What champion has the ultimate 'Glacial Prison'?" },
                    { 26, null, "Which map is played in ARAM mode?" },
                    { 27, null, "What passive effect does the Elder Dragon grant?" },
                    { 28, null, "Which champion is not associated with Demacia?" },
                    { 29, null, "What ability is common to all champions?" },
                    { 30, null, "Which champion was once a prince?" },
                    { 31, null, "Which item evolves Pikachu into Raichu?" },
                    { 32, null, "Who is the leader of Team Rocket?" },
                    { 33, null, "Which Pokemon does not evolve?" },
                    { 34, null, "What type is Mewtwo?" },
                    { 35, null, "What does TM stand for?" },
                    { 36, null, "What is the effect of the move 'Splash'?" },
                    { 37, null, "Who gives you your first Pokemon in Red and Blue?" },
                    { 38, null, "Which Pokemon is known as the mascot of the series?" },
                    { 39, null, "What type is effective against Ghost type?" },
                    { 40, null, "Which legendary bird is an Ice type?" },
                    { 41, null, "What is unique about the Unown Pokemon?" },
                    { 42, null, "What is the main goal of the Pokemon games?" },
                    { 43, null, "Which item is necessary to evolve Onix into Steelix?" },
                    { 44, null, "What type of move is 'Hyper Beam'?" },
                    { 45, null, "What is Pikachu's primary type?" },
                    { 46, null, "What is the command to buy an AK-47 in the console?" },
                    { 47, null, "Which map has a bombsite in an Atrium?" },
                    { 48, null, "What is the maximum number of players on a competitive team?" },
                    { 49, null, "Which gun is known for being the most accurate?" },
                    { 50, null, "What does the term 'eco' mean in gameplay?" },
                    { 51, null, "What is the function of a flashbang?" },
                    { 52, null, "Which map features a rescue mission?" },
                    { 53, null, "What is the default pistol for Terrorists?" },
                    { 54, null, "What weapon is commonly referred to as the 'noob cannon'?" },
                    { 55, null, "Which grenade is most effective against armored opponents?" },
                    { 56, null, "What map is known for its long sightlines and sniper battles?" },
                    { 57, null, "Which CS:GO operation introduced player skins?" },
                    { 58, null, "What is a 'smurf' in CS:GO?" },
                    { 59, null, "Which weapon has a 'burst' fire mode?" },
                    { 60, null, "What does 'B site' refer to?" },
                    { 61, null, "Which game first introduced Yoshi?" },
                    { 62, null, "What power-up causes Mario to grow larger?" },
                    { 63, null, "What is the primary antagonist's name in most Mario games?" },
                    { 64, null, "Which game is set in Dinosaur Land?" },
                    { 65, null, "What character is Mario's brother?" },
                    { 66, null, "In which game does Mario first encounter the character Wario?" },
                    { 67, null, "What kingdom does Peach rule over?" },
                    { 68, null, "What color are Mario's overalls?" },
                    { 69, null, "Which game did Mario first appear in?" },
                    { 70, null, "What vehicle does Mario use in Mario Kart?" },
                    { 71, null, "What is the name of Mario's dinosaur friend?" },
                    { 72, null, "Which game introduces Mario's flying raccoon suit?" },
                    { 73, null, "What fruit does Yoshi eat to gain power-ups?" },
                    { 74, null, "Which game features Mario as a plumber?" },
                    { 75, null, "Who is Mario's usual nemesis in the Donkey Kong series?" },
                    { 76, null, "What is the name of Link's green cap?" },
                    { 77, null, "Which game involves traveling between two parallel worlds?" },
                    { 78, null, "Who teaches Link the 'Spin Attack'?" },
                    { 79, null, "What is Zelda's alter ego in 'Ocarina of Time'?" },
                    { 80, null, "What weapon is most effective against Ganon?" },
                    { 81, null, "What instrument does Link play in 'The Wind Waker'?" },
                    { 82, null, "Which Zelda game is set on an island?" },
                    { 83, null, "Who is the creator of The Legend of Zelda series?" },
                    { 84, null, "What is the Triforce?" },
                    { 85, null, "Which item allows Link to travel through time in 'Ocarina of Time'?" },
                    { 86, null, "Who kidnaps Zelda in the original 'Legend of Zelda' game?" },
                    { 87, null, "What unique ability does Link have in 'Majora's Mask'?" },
                    { 88, null, "What color is the tunic Link wears by default?" },
                    { 89, null, "Which game did Link first appear in on the Nintendo Entertainment System?" },
                    { 90, null, "What is the name of the magical sword Link often uses?" }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "QuizId", "QuizName" },
                values: new object[,]
                {
                    { 1, "World of Warcraft Quiz" },
                    { 2, "League of Legends Quiz" },
                    { 3, "Pokemon Quiz" },
                    { 4, "Counter-Strike Quiz" },
                    { 5, "Super Mario Quiz" },
                    { 6, "The Legend of Zelda Quiz" },
                    { 7, "Mixed Game Quiz" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "Answer", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Orgrimmar", true, 1 },
                    { 2, "Undercity", false, 1 },
                    { 3, "Thunder Bluff", false, 1 },
                    { 4, "Silvermoon", false, 1 },
                    { 5, "Garrosh Hellscream", true, 2 },
                    { 6, "Vol'jin", false, 2 },
                    { 7, "Sylvanas Windrunner", false, 2 },
                    { 8, "Baine Bloodhoof", false, 2 },
                    { 9, "Blood Elf", true, 3 },
                    { 10, "Night Elf", false, 3 },
                    { 11, "Draenei", false, 3 },
                    { 12, "Goblin", false, 3 },
                    { 13, "Mists of Pandaria", true, 4 },
                    { 14, "Warlords of Draenor", false, 4 },
                    { 15, "Legion", false, 4 },
                    { 16, "Battle for Azeroth", false, 4 },
                    { 17, "Frostmourne", true, 5 },
                    { 18, "Ashbringer", false, 5 },
                    { 19, "Doomhammer", false, 5 },
                    { 20, "Shadowmourne", false, 5 },
                    { 21, "Nozdormu", true, 6 },
                    { 22, "Ysera", false, 6 },
                    { 23, "Malygos", false, 6 },
                    { 24, "Kalecgos", false, 6 },
                    { 25, "Pandaren", true, 7 },
                    { 26, "Troll", false, 7 },
                    { 27, "Tauren", false, 7 },
                    { 28, "Forsaken", false, 7 },
                    { 29, "Elementium", true, 8 },
                    { 30, "Saronite", false, 8 },
                    { 31, "Thorium", false, 8 },
                    { 32, "Titansteel", false, 8 },
                    { 33, "Ragnaros", true, 9 },
                    { 34, "Al'Akir", false, 9 },
                    { 35, "Nefarian", false, 9 },
                    { 36, "Cho'gall", false, 9 },
                    { 37, "Ysera", true, 10 },
                    { 38, "Alexstrasza", false, 10 },
                    { 39, "Neltharion", false, 10 },
                    { 40, "Khadgar", false, 10 },
                    { 41, "Warsong Gulch", true, 11 },
                    { 42, "Arathi Basin", false, 11 },
                    { 43, "Alterac Valley", false, 11 },
                    { 44, "Eye of the Storm", false, 11 },
                    { 45, "Black Temple", true, 12 },
                    { 46, "Sunwell Plateau", false, 12 },
                    { 47, "Karazhan", false, 12 },
                    { 48, "Naxxramas", false, 12 },
                    { 49, "Inscription", true, 13 },
                    { 50, "Herbalism", false, 13 },
                    { 51, "Alchemy", false, 13 },
                    { 52, "Jewelcrafting", false, 13 },
                    { 53, "Blasted Lands", true, 14 },
                    { 54, "Hellfire Peninsula", false, 14 },
                    { 55, "Shadowmoon Valley", false, 14 },
                    { 56, "Tanaan Jungle", false, 14 },
                    { 57, "Argus", true, 15 },
                    { 58, "Draenor", false, 15 },
                    { 59, "Azeroth", false, 15 },
                    { 60, "Outland", false, 15 },
                    { 61, "Jarvan IV", true, 16 },
                    { 62, "Garen", false, 16 },
                    { 63, "Darius", false, 16 },
                    { 64, "Xin Zhao", false, 16 },
                    { 65, "Blue Essence", true, 17 },
                    { 66, "Riot Points", false, 17 },
                    { 67, "Gold", false, 17 },
                    { 68, "Influence Points", false, 17 },
                    { 69, "Mage", true, 18 },
                    { 70, "Marksman", false, 18 },
                    { 71, "Support", false, 18 },
                    { 72, "Tank", false, 18 },
                    { 73, "40%", true, 19 },
                    { 74, "50%", false, 19 },
                    { 75, "35%", false, 19 },
                    { 76, "45%", false, 19 },
                    { 77, "Jax", true, 20 },
                    { 78, "Jayce", false, 20 },
                    { 79, "Tryndamere", false, 20 },
                    { 80, "Fiora", false, 20 },
                    { 81, "Kha'Zix", true, 21 },
                    { 82, "Rengar", false, 21 },
                    { 83, "Vel'Koz", false, 21 },
                    { 84, "Malzahar", false, 21 },
                    { 85, "Quinn", true, 22 },
                    { 86, "Caitlyn", false, 22 },
                    { 87, "Swain", false, 22 },
                    { 88, "Anivia", false, 22 },
                    { 89, "Sylas", true, 23 },
                    { 90, "Neeko", false, 23 },
                    { 91, "Zoe", false, 23 },
                    { 92, "Lux", false, 23 },
                    { 93, "Phantom Dancer", true, 24 },
                    { 94, "Statikk Shiv", false, 24 },
                    { 95, "Rapid Firecannon", false, 24 },
                    { 96, "Runaan's Hurricane", false, 24 },
                    { 97, "Sejuani", true, 25 },
                    { 98, "Ashe", false, 25 },
                    { 99, "Braum", false, 25 },
                    { 100, "Lissandra", false, 25 },
                    { 101, "Howling Abyss", true, 26 },
                    { 102, "Summoner's Rift", false, 26 },
                    { 103, "Twisted Treeline", false, 26 },
                    { 104, "Crystal Scar", false, 26 },
                    { 105, "Burn damage over time", true, 27 },
                    { 106, "Health regeneration", false, 27 },
                    { 107, "Increased damage output", false, 27 },
                    { 108, "Shield protection", false, 27 },
                    { 109, "Lux", true, 28 },
                    { 110, "Garen", false, 28 },
                    { 111, "Fiora", false, 28 },
                    { 112, "Xin Zhao", false, 28 },
                    { 113, "Flash", true, 29 },
                    { 114, "Heal", false, 29 },
                    { 115, "Ghost", false, 29 },
                    { 116, "Barrier", false, 29 },
                    { 117, "Jarvan IV", true, 30 },
                    { 118, "Malzahar", false, 30 },
                    { 119, "Azir", false, 30 },
                    { 120, "Viktor", false, 30 },
                    { 121, "Thunder Stone", true, 31 },
                    { 122, "Water Stone", false, 31 },
                    { 123, "Fire Stone", false, 31 },
                    { 124, "Leaf Stone", false, 31 },
                    { 125, "Giovanni", true, 32 },
                    { 126, "Archer", false, 32 },
                    { 127, "Maxie", false, 32 },
                    { 128, "Cyrus", false, 32 },
                    { 129, "Ditto", true, 33 },
                    { 130, "Jigglypuff", false, 33 },
                    { 131, "Gyarados", false, 33 },
                    { 132, "Eevee", false, 33 },
                    { 133, "Psychic", true, 34 },
                    { 134, "Dark", false, 34 },
                    { 135, "Ghost", false, 34 },
                    { 136, "Fighting", false, 34 },
                    { 137, "Technical Machine", true, 35 },
                    { 138, "Type Modifier", false, 35 },
                    { 139, "Trainer's Medallion", false, 35 },
                    { 140, "Transformation Module", false, 35 },
                    { 141, "No effect", true, 36 },
                    { 142, "Small damage", false, 36 },
                    { 143, "Stat boost", false, 36 },
                    { 144, "Heals a little HP", false, 36 },
                    { 145, "Professor Oak", true, 37 },
                    { 146, "Professor Elm", false, 37 },
                    { 147, "Professor Birch", false, 37 },
                    { 148, "Professor Kukui", false, 37 },
                    { 149, "Pikachu", true, 38 },
                    { 150, "Charizard", false, 38 },
                    { 151, "Mewtwo", false, 38 },
                    { 152, "Jigglypuff", false, 38 },
                    { 153, "Dark", true, 39 },
                    { 154, "Psychic", false, 39 },
                    { 155, "Normal", false, 39 },
                    { 156, "Fighting", false, 39 },
                    { 157, "Articuno", true, 40 },
                    { 158, "Zapdos", false, 40 },
                    { 159, "Moltres", false, 40 },
                    { 160, "Ho-Oh", false, 40 },
                    { 161, "It has many forms", true, 41 },
                    { 162, "It is invisible", false, 41 },
                    { 163, "It changes type with weather", false, 41 },
                    { 164, "It can breed with any Pokémon", false, 41 },
                    { 165, "To become Pokémon Champion", true, 42 },
                    { 166, "To complete the Pokédex", false, 42 },
                    { 167, "To rescue the professor", false, 42 },
                    { 168, "To defeat Team Rocket", false, 42 },
                    { 169, "Metal Coat", true, 43 },
                    { 170, "Link Cable", false, 43 },
                    { 171, "Sun Stone", false, 43 },
                    { 172, "Moon Stone", false, 43 },
                    { 173, "Normal", true, 44 },
                    { 174, "Fighting", false, 44 },
                    { 175, "Fire", false, 44 },
                    { 176, "Dragon", false, 44 },
                    { 177, "Electric", true, 45 },
                    { 178, "Steel", false, 45 },
                    { 179, "Grass", false, 45 },
                    { 180, "Ice", false, 45 },
                    { 181, "buy ak47", true, 46 },
                    { 182, "purchase ak47", false, 46 },
                    { 183, "get ak47", false, 46 },
                    { 184, "ak47", false, 46 },
                    { 185, "Italy", true, 47 },
                    { 186, "Dust II", false, 47 },
                    { 187, "Aztec", false, 47 },
                    { 188, "Cobblestone", false, 47 },
                    { 189, "5", true, 48 },
                    { 190, "6", false, 48 },
                    { 191, "4", false, 48 },
                    { 192, "7", false, 48 },
                    { 193, "AWP", true, 49 },
                    { 194, "AK-47", false, 49 },
                    { 195, "M4A1", false, 49 },
                    { 196, "Glock", false, 49 },
                    { 197, "Saving money for future rounds", true, 50 },
                    { 198, "Buying the most expensive gear", false, 50 },
                    { 199, "Using eco weapons only", false, 50 },
                    { 200, "Rushing the opponent quickly", false, 50 },
                    { 201, "Blinds opponents temporarily", true, 51 },
                    { 202, "Causes damage over time", false, 51 },
                    { 203, "Silences footsteps", false, 51 },
                    { 204, "Marks enemies on the radar", false, 51 },
                    { 205, "Office", true, 52 },
                    { 206, "Hostage", false, 52 },
                    { 207, "Assault", false, 52 },
                    { 208, "Militia", false, 52 },
                    { 209, "Glock-18", true, 53 },
                    { 210, "USP-S", false, 53 },
                    { 211, "P250", false, 53 },
                    { 212, "Five-SeveN", false, 53 },
                    { 213, "Auto-sniper", true, 54 },
                    { 214, "Scout", false, 54 },
                    { 215, "AWP", false, 54 },
                    { 216, "AK-47", false, 54 },
                    { 217, "HE Grenade", true, 55 },
                    { 218, "Smoke Grenade", false, 55 },
                    { 219, "Flashbang", false, 55 },
                    { 220, "Decoy Grenade", false, 55 },
                    { 221, "Dust II", true, 56 },
                    { 222, "Train", false, 56 },
                    { 223, "Overpass", false, 56 },
                    { 224, "Cache", false, 56 },
                    { 225, "Operation Bravo", true, 57 },
                    { 226, "Operation Hydra", false, 57 },
                    { 227, "Operation Vanguard", false, 57 },
                    { 228, "Operation Bloodhound", false, 57 },
                    { 229, "An experienced player who plays in a lower-ranked account", true, 58 },
                    { 230, "A new player still learning the game", false, 58 },
                    { 231, "A player who frequently disconnects", false, 58 },
                    { 232, "A player who cheats", false, 58 },
                    { 233, "FAMAS", true, 59 },
                    { 234, "M4A1-S", false, 59 },
                    { 235, "AK-47", false, 59 },
                    { 236, "Glock-18", false, 59 },
                    { 237, "A bombsite on a map", true, 60 },
                    { 238, "A meeting area in the middle of the map", false, 60 },
                    { 239, "A weapon buy zone", false, 60 },
                    { 240, "A sniper's nest", false, 60 },
                    { 241, "Super Mario World", true, 61 },
                    { 242, "Super Mario Bros.", false, 61 },
                    { 243, "Super Mario 64", false, 61 },
                    { 244, "Super Mario Sunshine", false, 61 },
                    { 245, "Super Mushroom", true, 62 },
                    { 246, "Fire Flower", false, 62 },
                    { 247, "Starman", false, 62 },
                    { 248, "Cape Feather", false, 62 },
                    { 249, "Bowser", true, 63 },
                    { 250, "Wario", false, 63 },
                    { 251, "Donkey Kong", false, 63 },
                    { 252, "King Boo", false, 63 },
                    { 253, "Super Mario World", true, 64 },
                    { 254, "Super Mario Bros. 3", false, 64 },
                    { 255, "Super Mario Odyssey", false, 64 },
                    { 256, "Super Mario Galaxy", false, 64 },
                    { 257, "Luigi", true, 65 },
                    { 258, "Peach", false, 65 },
                    { 259, "Toad", false, 65 },
                    { 260, "Yoshi", false, 65 },
                    { 261, "Super Mario Land 2: 6 Golden Coins", true, 66 },
                    { 262, "Super Mario Bros.", false, 66 },
                    { 263, "Super Mario World", false, 66 },
                    { 264, "Mario Kart 64", false, 66 },
                    { 265, "Mushroom Kingdom", true, 67 },
                    { 266, "Dinosaur Land", false, 67 },
                    { 267, "Sarasaland", false, 67 },
                    { 268, "Isle Delfino", false, 67 },
                    { 269, "Blue", true, 68 },
                    { 270, "Red", false, 68 },
                    { 271, "Green", false, 68 },
                    { 272, "Yellow", false, 68 },
                    { 273, "Donkey Kong", true, 69 },
                    { 274, "Super Mario Bros.", false, 69 },
                    { 275, "Mario Bros.", false, 69 },
                    { 276, "Super Mario Land", false, 69 },
                    { 277, "Kart", true, 70 },
                    { 278, "Motorcycle", false, 70 },
                    { 279, "Bicycle", false, 70 },
                    { 280, "ATV", false, 70 },
                    { 281, "Yoshi", true, 71 },
                    { 282, "Birdo", false, 71 },
                    { 283, "Koopa", false, 71 },
                    { 284, "Wiggler", false, 71 },
                    { 285, "Super Mario Bros. 3", true, 72 },
                    { 286, "Super Mario World", false, 72 },
                    { 287, "Super Mario 64", false, 72 },
                    { 288, "Super Mario Odyssey", false, 72 },
                    { 289, "Apples", true, 73 },
                    { 290, "Bananas", false, 73 },
                    { 291, "Cherries", false, 73 },
                    { 292, "Berries", false, 73 },
                    { 293, "Super Mario Bros.", true, 74 },
                    { 294, "Super Mario World", false, 74 },
                    { 295, "Super Mario 64", false, 74 },
                    { 296, "Super Mario Sunshine", false, 74 },
                    { 297, "Donkey Kong", true, 75 },
                    { 298, "King K. Rool", false, 75 },
                    { 299, "Diddy Kong", false, 75 },
                    { 300, "Cranky Kong", false, 75 },
                    { 301, "The Minish Cap", true, 76 },
                    { 302, "The Wind Cap", false, 76 },
                    { 303, "The Phantom Cap", false, 76 },
                    { 304, "The Time Cap", false, 76 },
                    { 305, "A Link to the Past", true, 77 },
                    { 306, "Ocarina of Time", false, 77 },
                    { 307, "The Wind Waker", false, 77 },
                    { 308, "Twilight Princess", false, 77 },
                    { 309, "Master Sword", true, 78 },
                    { 310, "Four Sword", false, 78 },
                    { 311, "Goddess Sword", false, 78 },
                    { 312, "Biggoron's Sword", false, 78 },
                    { 313, "Sheik", true, 79 },
                    { 314, "Tetra", false, 79 },
                    { 315, "Impa", false, 79 },
                    { 316, "Zelda", false, 79 },
                    { 317, "Master Sword", true, 80 },
                    { 318, "Silver Arrows", false, 80 },
                    { 319, "Light Arrows", false, 80 },
                    { 320, "Bomb Arrows", false, 80 },
                    { 321, "Wind Waker", true, 81 },
                    { 322, "Ocarina", false, 81 },
                    { 323, "Harp", false, 81 },
                    { 324, "Flute", false, 81 },
                    { 325, "Link's Awakening", true, 82 },
                    { 326, "Phantom Hourglass", false, 82 },
                    { 327, "Spirit Tracks", false, 82 },
                    { 328, "The Wind Waker", false, 82 },
                    { 329, "Shigeru Miyamoto", true, 83 },
                    { 330, "Eiji Aonuma", false, 83 },
                    { 331, "Satoshi Tajiri", false, 83 },
                    { 332, "Hideo Kojima", false, 83 },
                    { 333, "A sacred relic that bestows great power", true, 84 },
                    { 334, "A magical sword", false, 84 },
                    { 335, "A shield used by the Hylian Knights", false, 84 },
                    { 336, "A charm that protects against evil", false, 84 },
                    { 337, "Ocarina of Time", true, 85 },
                    { 338, "Master Sword", false, 85 },
                    { 339, "Twilight Mirror", false, 85 },
                    { 340, "Time Stones", false, 85 },
                    { 341, "Ganon", true, 86 },
                    { 342, "Vaati", false, 86 },
                    { 343, "Dark Link", false, 86 },
                    { 344, "Zant", false, 86 },
                    { 345, "Transform into different forms", true, 87 },
                    { 346, "Travel through time", false, 87 },
                    { 347, "Become invisible", false, 87 },
                    { 348, "Fly", false, 87 },
                    { 349, "Green", true, 88 },
                    { 350, "Blue", false, 88 },
                    { 351, "Red", false, 88 },
                    { 352, "White", false, 88 },
                    { 353, "The Legend of Zelda", true, 89 },
                    { 354, "Zelda II: The Adventure of Link", false, 89 },
                    { 355, "The Legend of Zelda: A Link to the Past", false, 89 },
                    { 356, "The Legend of Zelda: Link's Awakening", false, 89 },
                    { 357, "Master Sword", true, 90 },
                    { 358, "Kokiri Sword", false, 90 },
                    { 359, "Biggoron Sword", false, 90 },
                    { 360, "Phantom Sword", false, 90 }
                });

            migrationBuilder.InsertData(
                table: "QuestionMetaTags",
                columns: new[] { "MetaTagId", "QuestionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 },
                    { 2, 22 },
                    { 2, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 2, 26 },
                    { 2, 27 },
                    { 2, 28 },
                    { 2, 29 },
                    { 2, 30 },
                    { 3, 31 },
                    { 3, 32 },
                    { 3, 33 },
                    { 3, 34 },
                    { 3, 35 },
                    { 3, 36 },
                    { 3, 37 },
                    { 3, 38 },
                    { 3, 39 },
                    { 3, 40 },
                    { 3, 41 },
                    { 3, 42 },
                    { 3, 43 },
                    { 3, 44 },
                    { 3, 45 },
                    { 4, 46 },
                    { 4, 47 },
                    { 4, 48 },
                    { 4, 49 },
                    { 4, 50 },
                    { 4, 51 },
                    { 4, 52 },
                    { 4, 53 },
                    { 4, 54 },
                    { 4, 55 },
                    { 4, 56 },
                    { 4, 57 },
                    { 4, 58 },
                    { 4, 59 },
                    { 4, 60 },
                    { 5, 61 },
                    { 5, 62 },
                    { 5, 63 },
                    { 5, 64 },
                    { 5, 65 },
                    { 5, 66 },
                    { 5, 67 },
                    { 5, 68 },
                    { 5, 69 },
                    { 5, 70 },
                    { 5, 71 },
                    { 5, 72 },
                    { 5, 73 },
                    { 5, 74 },
                    { 5, 75 },
                    { 6, 76 },
                    { 6, 77 },
                    { 6, 78 },
                    { 6, 79 },
                    { 6, 80 },
                    { 6, 81 },
                    { 6, 82 },
                    { 6, 83 },
                    { 6, 84 },
                    { 6, 85 },
                    { 6, 86 },
                    { 6, 87 },
                    { 6, 88 },
                    { 6, 89 },
                    { 6, 90 }
                });

            migrationBuilder.InsertData(
                table: "QuizQuestions",
                columns: new[] { "QuestionId", "QuizId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 },
                    { 22, 2 },
                    { 23, 2 },
                    { 24, 2 },
                    { 25, 2 },
                    { 26, 2 },
                    { 27, 2 },
                    { 28, 2 },
                    { 29, 2 },
                    { 30, 2 },
                    { 31, 3 },
                    { 32, 3 },
                    { 33, 3 },
                    { 34, 3 },
                    { 35, 3 },
                    { 36, 3 },
                    { 37, 3 },
                    { 38, 3 },
                    { 39, 3 },
                    { 40, 3 },
                    { 41, 3 },
                    { 42, 3 },
                    { 43, 3 },
                    { 44, 3 },
                    { 45, 3 },
                    { 46, 4 },
                    { 47, 4 },
                    { 48, 4 },
                    { 49, 4 },
                    { 50, 4 },
                    { 51, 4 },
                    { 52, 4 },
                    { 53, 4 },
                    { 54, 4 },
                    { 55, 4 },
                    { 56, 4 },
                    { 57, 4 },
                    { 58, 4 },
                    { 59, 4 },
                    { 60, 4 },
                    { 61, 5 },
                    { 62, 5 },
                    { 63, 5 },
                    { 64, 5 },
                    { 65, 5 },
                    { 66, 5 },
                    { 67, 5 },
                    { 68, 5 },
                    { 69, 5 },
                    { 70, 5 },
                    { 71, 5 },
                    { 72, 5 },
                    { 73, 5 },
                    { 74, 5 },
                    { 75, 5 },
                    { 76, 6 },
                    { 77, 6 },
                    { 78, 6 },
                    { 79, 6 },
                    { 80, 6 },
                    { 81, 6 },
                    { 82, 6 },
                    { 83, 6 },
                    { 84, 6 },
                    { 85, 6 },
                    { 86, 6 },
                    { 87, 6 },
                    { 88, 6 },
                    { 89, 6 },
                    { 90, 6 },
                    { 1, 7 },
                    { 3, 7 },
                    { 5, 7 },
                    { 16, 7 },
                    { 18, 7 },
                    { 20, 7 },
                    { 31, 7 },
                    { 33, 7 },
                    { 35, 7 },
                    { 46, 7 },
                    { 48, 7 },
                    { 61, 7 },
                    { 63, 7 },
                    { 76, 7 },
                    { 78, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionMetaTags_MetaTagId",
                table: "QuestionMetaTags",
                column: "MetaTagId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestions_QuestionId",
                table: "QuizQuestions",
                column: "QuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "QuestionMetaTags");

            migrationBuilder.DropTable(
                name: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "MetaTags");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
