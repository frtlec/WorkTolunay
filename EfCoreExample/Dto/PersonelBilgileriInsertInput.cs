using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreExample.Dto
{
    public class PersonelBilgileriInsertInput
    {
        public string adsoyad { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }

        public string tarih { get; set; }
        public string saat { get; set; }
    }
}
