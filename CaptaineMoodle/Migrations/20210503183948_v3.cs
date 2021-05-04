﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CaptaineMoodle.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeacherIdId",
                table: "Assignement",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8371733f-4f70-49a7-835c-0274a06b56cb");

            migrationBuilder.CreateIndex(
                name: "IX_Assignement_TeacherIdId",
                table: "Assignement",
                column: "TeacherIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignement_AspNetUsers_TeacherIdId",
                table: "Assignement",
                column: "TeacherIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignement_AspNetUsers_TeacherIdId",
                table: "Assignement");

            migrationBuilder.DropIndex(
                name: "IX_Assignement_TeacherIdId",
                table: "Assignement");

            migrationBuilder.DropColumn(
                name: "TeacherIdId",
                table: "Assignement");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "6227ccd2-82ce-487f-adc2-b39fa9d61e65");
        }
    }
}
