using Microsoft.EntityFrameworkCore.Migrations;

namespace UAS_DOTNET.Migrations
{
    public partial class tb_sikap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Guru",
                columns: table => new
                {
                    NUPTK = table.Column<string>(type: "varchar(767)", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Mata_Pelajaran = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Guru", x => x.NUPTK);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Siswa",
                columns: table => new
                {
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    NISN = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Jenis_Kelamin = table.Column<string>(type: "text", nullable: false),
                    Alamat = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Siswa", x => x.NIS);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Ekstrakurikuler",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Nama_Ekstrakurikuler = table.Column<string>(type: "text", nullable: false),
                    Grade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Ekstrakurikuler", x => x.Nomor);
                    table.ForeignKey(
                        name: "FK_Tb_Ekstrakurikuler_Tb_Siswa_NIS",
                        column: x => x.NIS,
                        principalTable: "Tb_Siswa",
                        principalColumn: "NIS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Kehadiran",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Sakit = table.Column<string>(type: "text", nullable: false),
                    Izin = table.Column<string>(type: "text", nullable: false),
                    Tanpa_Keterangan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Kehadiran", x => x.Nomor);
                    table.ForeignKey(
                        name: "FK_Tb_Kehadiran_Tb_Siswa_NIS",
                        column: x => x.NIS,
                        principalTable: "Tb_Siswa",
                        principalColumn: "NIS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Mata_Pelajaran",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Pendidikan_Agama = table.Column<string>(type: "text", nullable: false),
                    PPKN = table.Column<string>(type: "text", nullable: false),
                    Bahasa_Indonesia = table.Column<string>(type: "text", nullable: false),
                    Matematika = table.Column<string>(type: "text", nullable: false),
                    IPA = table.Column<string>(type: "text", nullable: false),
                    IPS = table.Column<string>(type: "text", nullable: false),
                    PJOK = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Mata_Pelajaran", x => x.Nomor);
                    table.ForeignKey(
                        name: "FK_Tb_Mata_Pelajaran_Tb_Siswa_NIS",
                        column: x => x.NIS,
                        principalTable: "Tb_Siswa",
                        principalColumn: "NIS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Prestasi",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Jenis_Prestasi = table.Column<string>(type: "text", nullable: false),
                    Deskripsi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Prestasi", x => x.Nomor);
                    table.ForeignKey(
                        name: "FK_Tb_Prestasi_Tb_Siswa_NIS",
                        column: x => x.NIS,
                        principalTable: "Tb_Siswa",
                        principalColumn: "NIS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Sikap",
                columns: table => new
                {
                    Nomor = table.Column<string>(type: "varchar(767)", nullable: false),
                    NIS = table.Column<string>(type: "varchar(767)", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    Deskripsi_Sikap = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Sikap", x => x.Nomor);
                    table.ForeignKey(
                        name: "FK_Tb_Sikap_Tb_Siswa_NIS",
                        column: x => x.NIS,
                        principalTable: "Tb_Siswa",
                        principalColumn: "NIS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Ekstrakurikuler_NIS",
                table: "Tb_Ekstrakurikuler",
                column: "NIS");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Kehadiran_NIS",
                table: "Tb_Kehadiran",
                column: "NIS");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Mata_Pelajaran_NIS",
                table: "Tb_Mata_Pelajaran",
                column: "NIS");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Prestasi_NIS",
                table: "Tb_Prestasi",
                column: "NIS");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Sikap_NIS",
                table: "Tb_Sikap",
                column: "NIS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Ekstrakurikuler");

            migrationBuilder.DropTable(
                name: "Tb_Guru");

            migrationBuilder.DropTable(
                name: "Tb_Kehadiran");

            migrationBuilder.DropTable(
                name: "Tb_Mata_Pelajaran");

            migrationBuilder.DropTable(
                name: "Tb_Prestasi");

            migrationBuilder.DropTable(
                name: "Tb_Sikap");

            migrationBuilder.DropTable(
                name: "Tb_Siswa");
        }
    }
}
