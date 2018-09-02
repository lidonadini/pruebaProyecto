using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Piloto.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    PermisoID = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.PermisoID);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    nombre = table.Column<string>(maxLength: 50, nullable: true),
                    descripcion = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RelacionRol_Permiso",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rolid = table.Column<int>(nullable: true),
                    PermisoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionRol_Permiso", x => x.id);
                    table.ForeignKey(
                        name: "FK_RelacionRol_Permiso_Permiso_PermisoID",
                        column: x => x.PermisoID,
                        principalTable: "Permiso",
                        principalColumn: "PermisoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelacionRol_Permiso_Rol_Rolid",
                        column: x => x.Rolid,
                        principalTable: "Rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelacionUsuario_Rol",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Usuarioid = table.Column<int>(nullable: true),
                    Rolid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionUsuario_Rol", x => x.id);
                    table.ForeignKey(
                        name: "FK_RelacionUsuario_Rol_Rol_Rolid",
                        column: x => x.Rolid,
                        principalTable: "Rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelacionUsuario_Rol_Usuario_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seguimiento_usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Usuarioid = table.Column<int>(nullable: true),
                    actividad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguimiento_usuario", x => x.id);
                    table.ForeignKey(
                        name: "FK_Seguimiento_usuario_Usuario_Usuarioid",
                        column: x => x.Usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelacionRol_Permiso_PermisoID",
                table: "RelacionRol_Permiso",
                column: "PermisoID");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionRol_Permiso_Rolid",
                table: "RelacionRol_Permiso",
                column: "Rolid");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionUsuario_Rol_Rolid",
                table: "RelacionUsuario_Rol",
                column: "Rolid");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionUsuario_Rol_Usuarioid",
                table: "RelacionUsuario_Rol",
                column: "Usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Seguimiento_usuario_Usuarioid",
                table: "Seguimiento_usuario",
                column: "Usuarioid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelacionRol_Permiso");

            migrationBuilder.DropTable(
                name: "RelacionUsuario_Rol");

            migrationBuilder.DropTable(
                name: "Seguimiento_usuario");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
