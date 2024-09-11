using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Fixedsomespelligissues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 21, 34, 549, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                column: "ImageUrl",
                value: "../src/assets/images/LeagueOfLegends.webp");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                column: "ImageUrl",
                value: "../src/assets/images/CS.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 2,
                column: "ImageUrl",
                value: "../src/assets/images/LeaguefLegends.webp");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                column: "ImageUrl",
                value: "../src/assets/images/CS.jpeg");
        }
    }
}
