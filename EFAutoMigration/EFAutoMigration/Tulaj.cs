using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAutoMigration
{
    [Table("tulaj")]
    public class Tulaj
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TulajId { get; set; }
        public String Nev { get; set; }
        public string Telefonszam { get; set; }

        public List<Auto> Autok { get; set; }
    }
}
