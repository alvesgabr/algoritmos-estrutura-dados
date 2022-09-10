using System;
using System.Collections.Generic;

class U01S04EC07 {
  static void PrintS(Stack<int> og){
    foreach(int n in og){
      Console.Write($"{n} ");
    }
  }
  static void Inverter(Stack<int> og){
    Queue<int> temp = new Queue<int>(og.Count);
    while(og.Count > 0){
      temp.Enqueue(og.Pop());
    }
    while(temp.Count > 0){
      og.Push(temp.Dequeue());
    }
  }
  static void Main(string[] args){
    Stack<int> s = new Stack<int>();
    for(int n = 0; n <= 20; n++){
      s.Push(n);
    }
    Console.Write("B: ");
    PrintS(s);

    Inverter(s);

    Console.Write("\nA: ");
    PrintS(s);
  }
}

// Faça o método public void InverteStack<T> (Stack<T>  s) que inverte a ordem dos elementos do Stack<T> s, no próprio Stack. Nesse exercício, você não deve utilizar o método Reverse.