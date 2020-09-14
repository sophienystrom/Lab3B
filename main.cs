using System;

class MainClass {
  public static void Main (string[] args) {
   Console.WriteLine ("Enter saleperson name");
    var name = Console.ReadLine ();
    Console.WriteLine ("Enter sales amount");
    var sales = Console.ReadLine();
    Double y = Convert.ToDouble(sales);
    var commission = (200+(0.09 * y));
    Console.WriteLine ("Sales commission for " + name + " is $" + commission);
    if ( y <= 2999 && y >=0 ) {
      Console.WriteLine("Performance is poor"); }
    if ( y <= 4999 && y >= 3000) {
      Console.WriteLine("Performance is average"); 
    }
    if ( y <= 9999 && y >= 5000) {
      Console.WriteLine ("Performance is good");
    }
    if ( y <= 14999 && y >= 10000) { Console.WriteLine("Performance is excellent"); }
    if ( y >= 15000) {
      Console.WriteLine ("Performance is outstanding");
    }
    
  }
}