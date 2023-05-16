using EntityFramework160523.DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFramework160523.DB
{
    //1-prima cosa da fare è di installare i pachetti nuget
    //2-creare un folder DB con n file quello piu importante è DBContext.cs
    // Lui eredita dal framework Dbcontext(è il layourt di comunicazione)
    //Il DBContext rappresenta tutti il DB, è il nostro metodo per comunicare con il DB
    //3-Andiamo dentro il file startup.cs
        public class DBContext : DbContext
        {
        //costruttore vuoto
            public DBContext(DbContextOptions<DBContext> options)
                : base(options)
            {
            }
        //questa è una property che mappa la tabella
        //Questa 'DbSet' è una collezione particolare di tipo Person
        //Questa è la rappresentazione di una tabella scritta in classe
        public DbSet<Person> Persons { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                // Customize the ASP.NET Identity model and override the defaults if needed.
                // For example, you can rename the ASP.NET Identity table names and more.
                // Add your customizations after calling base.OnModelCreating(builder);
            }
        }
    
}
