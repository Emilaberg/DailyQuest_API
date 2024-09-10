using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class addedpropnamedImageUrlinQuizModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Quizzes",
                type: "nvarchar(max)",
                nullable: true);

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
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7,
                column: "ImageUrl",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Quizzes");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 10, 11, 8, 11, 133, DateTimeKind.Local).AddTicks(7236));
        }
    }
}
