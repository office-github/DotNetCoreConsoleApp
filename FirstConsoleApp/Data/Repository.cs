using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FirstConsoleApp.Data
{
  public class Repository<T> where T: class
  {
    private readonly DBContext context;

    public Repository(DBContext context)
    {
      this.context = context;
    }

    private DbSet<T> Entities => this.context.Set<T>();

    public IQueryable<T> Table => this.Entities;
  }
}
