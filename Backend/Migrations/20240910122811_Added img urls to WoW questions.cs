using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedimgurlstoWoWquestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 14, 28, 10, 967, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1,
                column: "Image",
                value: "..src/assets/images/Cities WoW.webp");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2,
                column: "Image",
                value: "..src/assets/images/ORC.webp");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3,
                column: "Image",
                value: "..src/assets/images/World_of_Warcraft_The_Burning_Crusade.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4,
                column: "Image",
                value: "..src/assets/images/WorldMap - Pandaria.webp");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5,
                column: "Image",
                value: "..src/assets/images/FrostMorn.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6,
                column: "Image",
                value: "..src/assets/images/FrostMorn.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7,
                column: "Image",
                value: "..src/assets/images/Class.jpg");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8,
                column: "Image",
                value: "..src/assets/images/ThunderFury.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9,
                column: "Image",
                value: "..src/assets/images/ThunderFury.png");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10,
                column: "Image",
                value: "..src/assets/images/dragon.jpg");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11,
                column: "Image",
                value: "..src/assets/images/WSG.webp");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12,
                column: "Image",
                value: "..src/assets/images/Illidan_the_Betrayer.webp");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13,
                column: "Image",
                value: "..src/assets/images/glyphs.webp");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14,
                column: "Image",
                value: "..src/assets/images/DarkPortal.webp");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15,
                column: "Image",
                value: "..src/assets/images/Dranei.webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 28, 44, 172, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15,
                column: "Image",
                value: null);
        }
    }
}
