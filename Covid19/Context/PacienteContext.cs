using Covid19.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Context
{
    public class PacienteContext : DbContext
    {
        public PacienteContext()
        {

        }

        public PacienteContext(DbContextOptions<PacienteContext> options) : base(options)
        {
        }

        public virtual DbSet<Paciente> paciente { get; set; }

        public virtual DbSet<Login> logins { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                        .AddJsonFile("appsettings.json")
                                        .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DataBase"));
            }
        }
    }

}
    