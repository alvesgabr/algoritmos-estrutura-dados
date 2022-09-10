using System;
using System.Collections.Generic;

// gabarito 02 - queues and stack

class U01S04GA02 {
  public static void Main(string[] args){
  Queue<int> f = new Queue<int>();
  f.Enqueue(1);
  f.Enqueue(2);
  f.Enqueue(3);
  Console.Write($"F: {f.Contains(1)} - {f.Count} - {f.Peek()}");
  Console.WriteLine(f.Dequeue());
  Console.Write($"F: {f.Contains(1)} - {f.Count} - {f.Peek()}");
  
  Stack<int> p = new Stack<int>();
  p.Push(1);
  p.Push(2);
  p.Push(3);
  Console.Write($"P: {p.Contains(1)} - {p.Count} - {p.Peek()}");
  Console.WriteLine(p.Pop());
  Console.Write($"P: {p.Contains(1)} - {p.Count} - {p.Peek()}");
  }
}