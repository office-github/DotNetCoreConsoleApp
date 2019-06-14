using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;

namespace FirstConsoleApp.Data
{
  public class DBContext: DbContext
  {
    private string _connectionString = "Data Source=DESKTOP-H57LPED;Initial Catalog=Practice;User ID=sa;Password=123;MultipleActiveResultSets=true";

    public DBContext() { }

    public DBContext(IConfiguration configuration)
    {
      _connectionString = configuration.GetConnectionString("Default");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      foreach(Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
      {
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
      }
    }
  }
}
