namespace filmadi
{
    using Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CINE_404 : DbContext
    {
       
        public CINE_404()
            : base("name=CINE_404ConnectionString")
        {
        }
        public DbSet<Film>Films { get; set; }  
        public DbSet<Yonetmen>Yonetmens { get; set; }
        public DbSet<Oyuncu>Oyuncus { get; set; }
    }

 
}