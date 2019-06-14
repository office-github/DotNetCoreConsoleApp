using FirstConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace FirstConsoleApp.Services
{
  public class GenericService
  {
    public GenericService()
    {

    }

    public List<T> GetList<T>() where T: class
    {
      return  this.ExecuteWithResult<T, List<T>>((repository) => {
        return repository.Table.ToList();
      });
    }

    private TResult ExecuteWithResult<TEntity, TResult>(Func<Repository<TEntity>, TResult> func) where TEntity: class
    {
      using(DBContext context = new DBContext())
      {
        try
        {
          return func(new Repository<TEntity>(context));
        }
        catch(SqlException ex)
        {
          Console.WriteLine(ex);
          throw new Exception("Error Occured.");
        }
      }
    }
  }
}
