using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmadi.Entity
{
    public class Yonetmen
    {
        public int YonetmenID { get; set; }
        public string YonetmenAdSoyad { get; set; }

        public ICollection<Oyuncu> YonetmenOyunculari { get; set; }

        public Yonetmen() { }
    }
}
