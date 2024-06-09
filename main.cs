using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("please enter a number");
    var num = Convert.ToInt32(Console.ReadLine());
    var factors = Enumerable.Range(1, num).Where((n) => num % n == 0).ToList();

    foreach (var n in factors) {
      Console.WriteLine(n);
    }
  }
}