using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Models
{
    public class Ekstrakurikuler
    {
        [Key]
        public string Nomor { get; set; }
        [Required]
        public string NIS { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Nama_Ekstrakurikuler { get; set; }
        [Required]
        public string Grade { get; set; }
    }
}
