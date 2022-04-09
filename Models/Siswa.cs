using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Models
{
    public class Siswa
    {
        [Key]
        public string NIS { get; set; }
        [Required]
        public string NISN { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Jenis_Kelamin { get; set; }
        [Required]
        public string Alamat { get; set; }
    }
}
