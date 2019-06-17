using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MusicBrainz.Api.Domain.Repositories;
using MusicBrainz.Api.Domain.Services;
using MusicBrainz.Api.Persistence.Contexts;
using MusicBrainz.Api.Persistence.Repositories;
using MusicBrainz.Api.Services;
using Newtonsoft.Json;

namespace MusicBrainz.Api
{
    /// <summary>
    /// Startup Class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configuration
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Startup
        /// </summary>
        /// <param name="env"></param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();
            Configuration = builder.Build();
            var environment = Configuration["ApplicationSettings:Environment"];

        }

        /// <summary>
        /// ConfigureServices
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddDbContext<MBDbContext>(option => option.UseSqlServer(@"Data Source =PBIO-2640\MSSQLSERVER2014;Initial Catalog=MusicBrainzDB;user=sa;password=Asdcxz1+ "));
            services.AddDbContext<MBDbContext>(option => option.UseSqlServer(Configuration.GetConnectionString("MusicBrainzConn")));
            services.AddScoped<IArtistRepository, ArtistRepository>();
            services.AddScoped<IArtistService, ArtistService>();

            //services.AddAutoMapper();
            services.AddAutoMapper(typeof(Startup));

            services.AddMvc().AddJsonOptions(options => { options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });
            //services.AddMvc().AddXmlSerializerFormatters();//Allow Json and XML 
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="mBDbContext"></param>
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MBDbContext mBDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            mBDbContext.Database.EnsureCreated();//check if database exist | when database structure tables columns will not change
            //MBDbContext.Database.Migrate();// when database will change in the future
            app.UseMvc();
        }
    }
}
