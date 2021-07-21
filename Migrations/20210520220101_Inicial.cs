using Microsoft.EntityFrameworkCore.Migrations;

namespace RRHH.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Parametro",
            //    columns: table => new
            //    {
            //        ID_PARAM = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CODIGO_TR = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CENTRO = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CUENTA_DB = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CUENTA_CR = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DESCRIPCION = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PS_CA_PARAM", x => x.ID_PARAM);
            //    });

            migrationBuilder.CreateTable(
                name: "PS_CA_TIPO_CHEQUE",
                columns: table => new
                {
                    ID_TIPO_CHEQUE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_TIPO_CHEQUE = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DESCRIPCION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PS_CA_TIPO_CHEQUE", x => x.ID_TIPO_CHEQUE);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PS_CA_PARAM");

            migrationBuilder.DropTable(
                name: "PS_CA_TIPO_CHEQUE");
        }
    }
}
