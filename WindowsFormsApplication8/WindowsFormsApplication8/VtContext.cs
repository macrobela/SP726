using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication8
{
    public class VtContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet MyProperty { get; set; }


    }
}
