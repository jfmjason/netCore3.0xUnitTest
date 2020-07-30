using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCPortal.Infra.Data.Migrations.Data
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VC_TemplatesByContract",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNo = table.Column<int>(nullable: false),
                    CardType = table.Column<string>(maxLength: 100, nullable: true),
                    Scheme = table.Column<string>(maxLength: 100, nullable: true),
                    Network = table.Column<string>(maxLength: 100, nullable: true),
                    PolicyNo = table.Column<string>(maxLength: 100, nullable: true),
                    FilePath = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VC_TemplatesByContract", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VC_TemplatesByMembershipNo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipNo = table.Column<int>(nullable: false),
                    ContractNo = table.Column<int>(nullable: false),
                    Scheme = table.Column<string>(maxLength: 100, nullable: false),
                    FilePath = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VC_TemplatesByMembershipNo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VC_TemplatesByScheme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchemeName = table.Column<string>(maxLength: 500, nullable: false),
                    ContractNo = table.Column<string>(maxLength: 50, nullable: false),
                    FilePath = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VC_TemplatesByScheme", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VC_TemplatesByContract");

            migrationBuilder.DropTable(
                name: "VC_TemplatesByMembershipNo");

            migrationBuilder.DropTable(
                name: "VC_TemplatesByScheme");
        }
    }
}
