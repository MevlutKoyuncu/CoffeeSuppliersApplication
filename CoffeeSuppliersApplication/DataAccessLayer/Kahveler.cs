using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class Kahveler
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Satici { get; set; }
        public string UreticiUlke { get; set; }
        public decimal fiyat { get; set; }
        public int stok { get; set; }
        public bool satistami { get; set; }
    }
}
