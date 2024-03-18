using E_Com.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Com.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Category {  get; set; }

        private static readonly string[] separator = new String[] { @"bin\" };

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var env_name = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                string projectPath = AppDomain.CurrentDomain.BaseDirectory.Split(separator, StringSplitOptions.None)[0];
                IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                 .AddJsonFile($"appsettings.{env_name}.json")
                 .Build();
                var config = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseMySql(config, ServerVersion.AutoDetect(config));
            }
        }
    }
}
