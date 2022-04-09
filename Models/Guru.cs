using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UAS_DOTNET.Models
{
    public class Guru
    {
        [Key]
        [Required]
        [DisplayName("NUPTK")]
        public string NUPTK { get; set; }

        [Required]
        [DisplayName("Nama")]
        public string Nama { get; set; }

        [Required]
        [DisplayName("Mata Pelajaran")]
        public string Mata_Pelajaran { get; set; }
    }
}
