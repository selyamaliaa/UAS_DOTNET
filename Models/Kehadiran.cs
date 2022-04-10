using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Models
{
    public class Kehadiran
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
    }
}
