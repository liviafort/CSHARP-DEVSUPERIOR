using System;
using System.Globalization;

namespace Course{
  class Program{

    static void Main(string[] args){
      Product p1 = new("Lívia", 1.20, 4);
      Console.WriteLine(p1.ToString());

      Product p2 = new("Lívia2", 176);
      Console.WriteLine(p2.ToString());

      p1.Nome = "liviaoiii";
      Console.WriteLine(p1.ToString());

    }

  }
}