using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Models
{
    public class Personel : Gunler
    {
        [Key]
        public int Id { get; set; }
        public int DepatmanId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }


    }
}
