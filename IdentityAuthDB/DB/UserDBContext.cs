﻿using IdentityAuthDB.DB.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityAuthDB.DB
{
    //Questa class UserDBContext eredita la classe IdentityDbContext<User> del framework
    //e questa classe mi da le funzionalità base del framework
    //Una volta creata questa classe abbiamo il dbcontext per gestire authetificazione
    public class UserDBContext :IdentityDbContext<User>
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
