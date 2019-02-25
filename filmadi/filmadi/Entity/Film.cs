using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmadi.Entity
{
    public class Film
    {
        //[MaxLength(10)]
        public int FilmID { get; set; }
        public int FilmYonetmenID { get; set; }
        public string FilmAd{ get; set; }

        public ICollection<Oyuncu> FilmOyuncuları { get; set; }

       public Film() { }
        
    }
}
