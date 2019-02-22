using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OgrenciCalismaEntityFramework
{
    public class Entity
    {
        public int HastaID { get; set; }
        public int DoktorID { get; set; }
        public string HastaAdi { get; set; }
        public string DoktorAdi { get; set; }
        public DateTime RandevuZaman { get; set; }
        public int RandevuID { get; set; }
    }
}
