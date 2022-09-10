using System;
using System.Collections;

class U01S03RS05 {
  public static void Main(string[] args){
    Console.WriteLine($"Type a character:");
    Stack s = new Stack(10);
    char character;
    do {
      character = char.Parse(Console.ReadLine());
      if (char.IsUpper(character) == true){
        s.Push(character);
        Console.WriteLine($"#{character} - Added\n");
      } else if (char.IsLower(character) == true){
        Console.WriteLine($"#{s.Pop()} - Removed\n");
      } else {
        Console.WriteLine($"Peek: {s.Peek()}\n");
      }
    } while(s.Count <= 10);
  }
}