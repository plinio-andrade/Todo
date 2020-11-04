﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Todo.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: true),
                    User = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todo_User",
                table: "Todo",
                column: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
