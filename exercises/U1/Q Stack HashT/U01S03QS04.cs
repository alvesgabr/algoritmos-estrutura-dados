using System;
using System.Collections;

class U01S03RS04 {
  public static void Main(string[] args){
    Console.WriteLine($"Type a character:");
    Queue q = new Queue(10);
    char character;
    do {
      character = char.Parse(Console.ReadLine());
      if (char.IsUpper(character) == true){
        q.Enqueue(character);
        Console.WriteLine($"#{character} - Added\n");
      } else if (char.IsLower(character) == true){
        Console.WriteLine($"#{q.Dequeue()} - Removed\n");
      } else {
        Console.WriteLine($"Peek: {q.Peek()}\n");
      }
    } while(q.Count <= 10);
  }
}