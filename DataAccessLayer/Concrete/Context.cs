using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
namespace DataAccessLayer.Concrete
{
   public class Context:DbContext
    {
        public Context() : base("Data Source=MSI;Initial Catalog=DbMvcKampi;Integrated Security=True")
        {

        }

        //REFERANS EKLEYEREK ULAŞTIK KLASLARA ENTİTYLAYER SEÇTİK

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> writers { get; set; }

    }
}
