using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAutoMigration
{
    [Table("autok")]
    public class Auto
    {
        [Key]
        public string Rendszam { get; set; }
        [Required]
        public string Gyartmany { get; set; }
        [Required]
        public string Tipus { get; set; }
        [Required]
        public int GyartasiEv { get; set; }
    }
}
