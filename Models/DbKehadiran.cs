using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Models
{
    public class DbKehadiran
    {
        [Key]
        public string Nomor { get; set; }
        [Required]
        public string NIS { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Sakit { get; set; }
        [Required]
        public string Izin { get; set; }
        [Required]
        public string Tanpa_Keterangan { get; set; }

        [ForeignKey("NIS")]
        public Siswa fkNIS { get; set; }
    }
}
