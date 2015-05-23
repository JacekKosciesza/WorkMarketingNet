using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace WorkMarketingNet.Quotes.Data.Migrations
{
    public partial class Initial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column(type: "int", nullable: false),
                    Image = table.Column(type: "nvarchar(max)", nullable: true),
                    Name = table.Column(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.Id);
                });
            migration.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    Body = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column(type: "nvarchar(max)", nullable: true),
                    SourceId = table.Column(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quote_Source_SourceId",
                        columns: x => x.SourceId,
                        referencedTable: "Source",
                        referencedColumn: "Id");
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("Quote");
            migration.DropTable("Source");
        }
    }
}
