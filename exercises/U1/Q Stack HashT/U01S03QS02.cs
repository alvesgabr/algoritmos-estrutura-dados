using System;
using System.Collections;

class U01S03RS01 {
  public static void Main(string[] args){
    Queue q = new Queue();

    for (int i = 1; i <= 5; i++){
      q.Enqueue(i);
    }

    Console.WriteLine($"Current Q:");
    foreach (object o in q){
      Console.Write($"{o} ");
    }

    Console.WriteLine();

    Console.WriteLine($"#{q.Dequeue()} - Removed");

    if(q.Contains(1) == true){
      Console.WriteLine($"#1 - Found!");
    } else {
      Console.WriteLine($"#1 - Not found!");
    }    

    if(q.Contains(5) == true){
      Console.WriteLine($"#5 - Found!");
    } else {
      Console.WriteLine($"#5 - Not found!");
    }    
    
    Console.WriteLine($"Next: #{q.Peek()}");

    for (int i = 6; i <= 10; i++){
      q.Enqueue(i);
    }

    Console.WriteLine($"#{q.Dequeue()} / #{q.Dequeue()} - Removed");

    q.Clear();

    Console.WriteLine($"Values: {q.Count}");
  }
}