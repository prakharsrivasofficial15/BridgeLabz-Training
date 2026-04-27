using System;

class UnaryOperators {
  static void Main(string[] args) {
    int a = 5;
    
    Console.WriteLine("a: " + a); // 5
    Console.WriteLine("++a: " + ++a); // 6 (pre-increment)
    Console.WriteLine("a++: " + a++); // 6 (post-increment)
    Console.WriteLine("a: " + a); // 7
    Console.WriteLine("--a: " + --a); // 6 (pre-decrement)
    Console.WriteLine("a--: " + a--); // 6 (post-decrement)
    Console.WriteLine("a: " + a); // 5
  }
}
