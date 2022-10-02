using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class mesajlar
    {
        [Key]
        public int MesajID { get; set; }
        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Kimden { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Kime { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(50)]
        public string Baslik { get; set; }

        [Column(TypeName = "VarChar")]
        [StringLength(2000)]
        public string Mesaj { get; set; }

        [Column(TypeName = "Smalldatetime")]
        public DateTime Tarih { get; set; }

    }
}