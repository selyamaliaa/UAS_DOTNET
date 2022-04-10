using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Models
{
    public class MataPelajaran
    {
        [Key]
        public string Nomor { get; set; }
        [Required]
        public string NIS { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Pendidikan_Agama { get; set; }
        [Required]
        public string PPKN { get; set; }
        [Required]
        public string Bahasa_Indonesia { get; set; }
        [Required]
        public string Matematika { get; set; }
        [Required]
        public string IPA { get; set; }
        [Required]
        public string IPS { get; set; }
        [Required]
        public string PJOK { get; set; }
    }
}
