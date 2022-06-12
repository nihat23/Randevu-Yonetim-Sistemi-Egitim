using Entities;
using System.Data.Entity;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
            Database.SetInitializer(new DbInitializer()); // EF Database.SetInitializer metoduna kendi yapt���m�z DbInitializer s�n�f�n� yollad�k
        }
        //DbSetler veritaban� tablolar�m�z� temsil eden yap�lard�r
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Doktor> Doktorlar { get; set; }
        public virtual DbSet<Hasta> Hastalar { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<Randevu> Randevular { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
    }
}