﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace P03_SalesDatabase.Migrations
{
    public partial class SalesAddDateDefault : Migration
    {

            protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime));
        }

   

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                 name: "Date",
                 table: "Sales",
                 nullable: false,
                 oldClrType: typeof(DateTime),
                 oldDefaultValueSql: "getdate()");
        }
    }
}
