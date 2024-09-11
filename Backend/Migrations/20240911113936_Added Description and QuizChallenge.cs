using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedDescriptionandQuizChallenge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuizChallenge",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 39, 36, 367, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Dive into the rich lore, epic raids, and character classes of Azeroth as you tackle this World of Warcraft challenge.", "An expansive MMORPG set in a fantasy world where players create characters, complete quests, and battle in epic raids." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Prove your knowledge of champions, game mechanics, and legendary plays from the Summoner's Rift in this thrilling League of Legends quiz.", "A fast-paced multiplayer online battle arena (MOBA) where two teams of champions face off to destroy each other's Nexus." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Test your skills in identifying Pokémon, their types, evolutions, and battle strategies in this ultimate Pokémon quiz.", "A beloved RPG where players capture, train, and battle creatures called Pokémon, striving to become the ultimate Pokémon Master." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Show off your tactical knowledge, map awareness, and weapon expertise in this intense Counter-Strike quiz.", "A tactical first-person shooter that pits teams of terrorists and counter-terrorists against each other in intense, strategic combat." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Navigate through iconic levels, power-ups, and memorable characters from the Mario universe in this nostalgic Super Mario quiz.", "A classic platformer where Mario, a heroic plumber, navigates through levels to rescue Princess Peach from Bowser." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Challenge your understanding of legendary quests, dungeons, and characters from the timeless world of The Legend of Zelda.", "An action-adventure series featuring Link, a hero who explores dungeons, solves puzzles, and battles foes to save the kingdom of Hyrule." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Challenge yourself with a mixed quiz of the games, World of Warcraft, League of Legends, Pokemón, Counter-Strike, Super-Mario and The Legend of Zelda", "A mixed quiz with questions from the beloved games, World of Warcraft, League of Legends, Pokemon, Super Mario, Counter-Strike and The Legend of Zelda" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuizChallenge",
                table: "Quizzes");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 13, 2, 6, 249, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1,
                column: "QuizDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                column: "QuizDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3,
                column: "QuizDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                column: "QuizDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5,
                column: "QuizDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6,
                column: "QuizDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7,
                column: "QuizDescription",
                value: null);
        }
    }
}
