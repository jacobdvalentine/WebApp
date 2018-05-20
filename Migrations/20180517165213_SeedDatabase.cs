using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        // Populate SQL tables
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make1-ModelA', (SELECT ID FROM Makes WHERE Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Make2-ModelA', (SELECT ID FROM Makes WHERE Name = 'Make2'))");
        }

        // Downgrade tables
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Make1')");
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Make2')");

        }
    }
}
