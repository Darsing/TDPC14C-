using IdentityAuthDB.DB.Entities;
using IdentityAuthDB.DB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAuthDB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //questa � per la registrazione del dbcontext
            services.AddDbContext<UserDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AuthDB")));

            //User Management
            //questi servono per registrare i vari servizi che possono servire per gestire le utenze
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<UserDBContext>()
                .AddDefaultTokenProviders();
            //per considerare lo user in quanto utenza per authetificarsi
            services.AddScoped<SignInManager<User>>();
            //questa � operazione di login permette di gestire operazione di authetificazione
            services.AddScoped<UserManager<User>>();
            //gestisce l anagrafica del User
            //Da tutti le informazione sulla classe User creato da me dentro Entities
            services.AddScoped<RoleManager<IdentityRole>>();
            //gestisce anagrafe del role
            //Creato dal framework questa class <IdentityRole>
            //Qui non ho creato la classe Role che eredita da IdentityRole
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //devo agguingere questi 2 file di configurazione
            //Dicono alla mia Applicazione  guarda che la mia Applicazione usera un sistama
            //di auto-identificazione e di auto-autorisazione(per gestire i permessi che hai)
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
