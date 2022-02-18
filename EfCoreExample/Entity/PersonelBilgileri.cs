using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreExample.Entity
{
    public class PersonelBilgileri
    {
        [Key]
        public int mno { get; set; }     
        public string adsoyad { get; set; }     
        public string telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }
        public DateTime? tarihsaat { get; set; }
    }
}
