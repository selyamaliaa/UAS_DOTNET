using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Models
{
    public class Prestasi
    {
        [Key]
        public string Nomor { get; set; }
        [Required]
        public string NIS { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Jenis_Prestasi { get; set; }
        [Required]
        public string Deskripsi { get; set; }
    }
}
