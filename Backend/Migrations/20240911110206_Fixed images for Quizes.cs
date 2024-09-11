using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class FixedimagesforQuizes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuizDescription",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "ImageUrl", "QuizDescription" },
                values: new object[] { "../src/assets/images/cards/world-of-warcraft.png", null });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "QuizDescription" },
                values: new object[] { "../src/assets/images/LeaguefLegends.webp", null });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "QuizDescription" },
                values: new object[] { "../src/assets/images/Pokemon.jpeg", null });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "QuizDescription" },
                values: new object[] { "../src/assets/images/CS.jpeg", null });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "QuizDescription" },
                values: new object[] { "../src/assets/images/cards/Super_mario.png", null });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "QuizDescription" },
                values: new object[] { "../src/assets/images/Zelda.jpg", null });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7,
                columns: new[] { "ImageUrl", "QuizDescription" },
                values: new object[] { "../src/assets/images/MixedQuiz.webp", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuizDescription",
                table: "Quizzes");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 12, 14, 18, 179, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/src/assets/images/cards/world-of-warcraft.png");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/src/assets/images/LeaguefLegends.webp");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/src/assets/images/Pokemon.jpeg");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/src/assets/images/CS.jpeg");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5,
                column: "ImageUrl",
                value: "/src/assets/images/cards/Super_mario.png");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6,
                column: "ImageUrl",
                value: "/src/assets/images/Zelda.jpg");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7,
                column: "ImageUrl",
                value: "/src/assets/images/MixedQuiz.webp");
        }
    }
}
