using System;
using System.Collections;

class U01S03RS02 {
  public static void Main(string[] args){
    Stack s = new Stack();

    for(int i=1;i<=5;i++){
      s.Push(i);
    }

    Console.WriteLine($"Current Stack:");
    foreach(object o in s){
      Console.Write($"{o} ");
    }

    Console.WriteLine();

    Console.WriteLine($"Values: {s.Count}");

    Console.WriteLine($"{s.Pop()} - Removed");

    if (s.Contains(1) == true) {
      Console.WriteLine($"#1 - Found!");
    } else {
      Console.WriteLine($"#1 - Not found!");
    }

    if (s.Contains(5) == true) {
      Console.WriteLine($"#5 - Found!");
    } else {
      Console.WriteLine($"#5 - Not found!");
    }

    Console.WriteLine($"Next: {s.Peek()}");

    for(int i=6;i<=10;i++){
      s.Push(i);
    }

    Console.WriteLine($"{s.Pop()} | {s.Pop()} - Removed");

    s.Clear();

    Console.WriteLine($"Values: {s.Count}");
  }
}