using Microsoft.EntityFrameworkCore.Migrations;

namespace InstituicaoFundo.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cpf = table.Column<string>(type: "TEXT", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fundos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RazaoSocial = table.Column<string>(type: "TEXT", nullable: true),
                    DataInicio = table.Column<string>(type: "TEXT", nullable: true),
                    Saldo = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fundos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instituicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RazaoSocial = table.Column<string>(type: "TEXT", nullable: true),
                    Cnpj = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundosCotados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cnpj = table.Column<string>(type: "TEXT", nullable: true),
                    ArtigoResolucao = table.Column<bool>(type: "INTEGER", nullable: false),
                    FundoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundosCotados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundosCotados_Fundos_FundoId",
                        column: x => x.FundoId,
                        principalTable: "Fundos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstituicoesContatos",
                columns: table => new
                {
                    InstituicaoId = table.Column<int>(type: "INTEGER", nullable: false),
                    ContatoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicoesContatos", x => new { x.InstituicaoId, x.ContatoId });
                    table.ForeignKey(
                        name: "FK_InstituicoesContatos_Contatos_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "Contatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstituicoesContatos_Instituicoes_InstituicaoId",
                        column: x => x.InstituicaoId,
                        principalTable: "Instituicoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstituicoesFundos",
                columns: table => new
                {
                    InstituicaoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FundoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicoesFundos", x => new { x.InstituicaoId, x.FundoId });
                    table.ForeignKey(
                        name: "FK_InstituicoesFundos_Fundos_FundoId",
                        column: x => x.FundoId,
                        principalTable: "Fundos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstituicoesFundos_Instituicoes_InstituicaoId",
                        column: x => x.InstituicaoId,
                        principalTable: "Instituicoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FundosCotados_FundoId",
                table: "FundosCotados",
                column: "FundoId");

            migrationBuilder.CreateIndex(
                name: "IX_InstituicoesContatos_ContatoId",
                table: "InstituicoesContatos",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_InstituicoesFundos_FundoId",
                table: "InstituicoesFundos",
                column: "FundoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FundosCotados");

            migrationBuilder.DropTable(
                name: "InstituicoesContatos");

            migrationBuilder.DropTable(
                name: "InstituicoesFundos");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Fundos");

            migrationBuilder.DropTable(
                name: "Instituicoes");
        }
    }
}
