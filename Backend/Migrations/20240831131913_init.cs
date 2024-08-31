using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailModels",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateLastSent = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailModels", x => x.EmailId);
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
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "QuizModels",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizModels", x => x.QuizId);
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
                        name: "FK_QuizQuestions_QuizModels_QuizId",
                        column: x => x.QuizId,
                        principalTable: "QuizModels",
                        principalColumn: "QuizId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EmailModels",
                columns: new[] { "EmailId", "DateLastSent", "Email" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6797), "Maxtharn@gmail.com" },
                    { 2, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6847), "Nckandero@gmail.com" },
                    { 3, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6849), "emil.aberg@live.com" },
                    { 4, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6851), "e.johannesnilsson@gmail.com" },
                    { 5, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6853), "emmzaa1337@gmail.com" },
                    { 6, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6854), "Din@Son.lol" },
                    { 7, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6856), "Din@Kusin.lol" },
                    { 8, new DateTime(2024, 8, 31, 15, 19, 12, 836, DateTimeKind.Local).AddTicks(6858), "oscar.sommerfors@gmail.com" }
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
                columns: new[] { "QuestionId", "Question" },
                values: new object[,]
                {
                    { 1, "Which dragon aspect was originally charged with protecting life on Azeroth?" },
                    { 2, "Who was the final boss of the original Naxxramas raid?" },
                    { 3, "Which champion was the first to be released in League of Legends?" },
                    { 4, "What is the name of the item that builds into Infinity Edge?" },
                    { 5, "Which Pokémon is known as the 'Aura Pokémon'?" },
                    { 6, "What item is used to evolve Eevee into Umbreon?" },
                    { 7, "Which map features the iconic AWP sniper duel at Long A?" },
                    { 8, "What is the default bomb timer in Counter-Strike: Global Offensive?" },
                    { 9, "Which game introduced Mario's ability to fly with the Cape Feather?" },
                    { 10, "What is the name of Mario’s dinosaur companion?" },
                    { 11, "Which Zelda game features the 'Temple of Time' as a central location?" },
                    { 12, "What is the name of Link’s talking boat in The Wind Waker?" }
                });

            migrationBuilder.InsertData(
                table: "QuizModels",
                columns: new[] { "QuizId", "QuizName" },
                values: new object[,]
                {
                    { 1, "Gaming Quiz" },
                    { 2, "Mixed Quiz" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "AnswerId", "Answer", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Alexstrasza", true, 1 },
                    { 2, "Ysera", false, 1 },
                    { 3, "Nozdormu", false, 1 },
                    { 4, "Malygos", false, 1 },
                    { 5, "Kel'Thuzad", true, 2 },
                    { 6, "Anub'Rekhan", false, 2 },
                    { 7, "Sapphiron", false, 2 },
                    { 8, "Patchwerk", false, 2 },
                    { 9, "Ashe", false, 3 },
                    { 10, "Twisted Fate", true, 3 },
                    { 11, "Alistar", false, 3 },
                    { 12, "Kayle", false, 3 },
                    { 13, "B.F. Sword", true, 4 },
                    { 14, "Long Sword", false, 4 },
                    { 15, "Pickaxe", false, 4 },
                    { 16, "Dagger", false, 4 },
                    { 17, "Lucario", true, 5 },
                    { 18, "Pikachu", false, 5 },
                    { 19, "Mewtwo", false, 5 },
                    { 20, "Charizard", false, 5 },
                    { 21, "Moon Stone", false, 6 },
                    { 22, "Friendship during nighttime", true, 6 },
                    { 23, "Thunder Stone", false, 6 },
                    { 24, "Dusk Stone", false, 6 },
                    { 25, "Dust II", true, 7 },
                    { 26, "Mirage", false, 7 },
                    { 27, "Inferno", false, 7 },
                    { 28, "Nuke", false, 7 },
                    { 29, "40 seconds", true, 8 },
                    { 30, "35 seconds", false, 8 },
                    { 31, "45 seconds", false, 8 },
                    { 32, "30 seconds", false, 8 },
                    { 33, "Super Mario World", true, 9 },
                    { 34, "Super Mario Bros. 3", false, 9 },
                    { 35, "Super Mario 64", false, 9 },
                    { 36, "Super Mario Sunshine", false, 9 },
                    { 37, "Yoshi", true, 10 },
                    { 38, "Bowser", false, 10 },
                    { 39, "Toad", false, 10 },
                    { 40, "Luigi", false, 10 },
                    { 41, "Ocarina of Time", true, 11 },
                    { 42, "Majora's Mask", false, 11 },
                    { 43, "The Wind Waker", false, 11 },
                    { 44, "Twilight Princess", false, 11 },
                    { 45, "King of Red Lions", true, 12 },
                    { 46, "Epona", false, 12 },
                    { 47, "Tetra", false, 12 },
                    { 48, "Phantom", false, 12 }
                });

            migrationBuilder.InsertData(
                table: "QuestionMetaTags",
                columns: new[] { "MetaTagId", "QuestionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 5, 6 },
                    { 6, 6 },
                    { 6, 7 }
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
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 }
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
                name: "EmailModels");

            migrationBuilder.DropTable(
                name: "QuestionMetaTags");

            migrationBuilder.DropTable(
                name: "QuizQuestions");

            migrationBuilder.DropTable(
                name: "MetaTags");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "QuizModels");
        }
    }
}
