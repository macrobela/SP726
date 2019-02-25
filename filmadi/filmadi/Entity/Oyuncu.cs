using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmadi.Entity
{
   public class Oyuncu
    {
        public int OyuncuID { get; set; }
        public string OyuncuAdSoyad { get; set; }
        public DateTime OyuncuDogumTarihi { get; set; }
        public ICollection<Yonetmen> YonetmenOyunculari { get; set; }

        public ICollection<Film> OyuncuFilmleri { get; set; }

        public Oyuncu () { }
    }
}
