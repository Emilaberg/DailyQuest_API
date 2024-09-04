using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddednullablestringcalledImageintheQuestionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 3, 15, 0, 45, 796, DateTimeKind.Local).AddTicks(8477));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "EmailModels",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 8, 31, 17, 11, 35, 889, DateTimeKind.Local).AddTicks(871));
        }
    }
}
