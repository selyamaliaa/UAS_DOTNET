using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UAS_DOTNET.Models;

namespace UAS_DOTNET.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Roles> Tb_Roles { get; set; }
        public virtual DbSet<User> Tb_User { get; set; }
        public virtual DbSet<DbEkstrakurikuler> Tb_Ekstrakurikuler { get; set; }
        public virtual DbSet<DbKehadiran> Tb_Kehadiran { get; set; }
        public virtual DbSet<DbMataPelajaran> Tb_Mata_Pelajaran { get; set; }
        public virtual DbSet<DbPrestasi> Tb_Prestasi { get; set; }
        public virtual DbSet<DbSikap> Tb_Sikap { get; set; }
        public virtual DbSet<Guru> Tb_Guru { get; set; }
        public virtual DbSet<Siswa> Tb_Siswa { get; set; }
    }
}
