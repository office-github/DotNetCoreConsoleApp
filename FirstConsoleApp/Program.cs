using FirstConsoleApp.Models;
using FirstConsoleApp.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace FirstConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Student Details");
      //IConfiguration configuration = GetAppSettingsFile();

      GenericService service = new GenericService();

      List<Student> students = service.GetList<Student>();

      foreach(Student student in students)
      {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
      }
    }

    //static IConfiguration GetAppSettingsFile() => 
    //        new ConfigurationBuilder()
    //        .SetBasePath(Directory.GetCurrentDirectory())
    //        .AddJsonFile("App.json", optional: false, reloadOnChange: true)
    //        .Build();
  }
}
