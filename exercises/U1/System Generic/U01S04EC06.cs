using System;
using System.Collections.Generic;

class U01S04EC06 {
  static void PrintQ(Queue<int> og){
    foreach(int n in og){
      Console.Write($"{n} ");
    }
  }
  static void Inverter(Queue<int> og){
    Stack<int> temp = new Stack<int>(og.Count);
    while(og.Count > 0){
      temp.Push(og.Dequeue());
    }
    while(temp.Count > 0){
      og.Enqueue(temp.Pop());
    }

  }
  static void Main(string[] args){
    Queue<int> q = new Queue<int>();
    for(int n = 0; n <= 20; n++){
      q.Enqueue(n);
    }
    Console.Write("B: ");
    PrintQ(q);

    Inverter(q);

    Console.Write("\nA: ");
    PrintQ(q);
  }
}

// Faça o método public void InverteQueue<T> (Queue<T> q) que inverte a ordem dos elementos da Queue<T> q, no próprio Queue. Fique à vontade para utilizar outras estruturas que julgar necessárias. Nesse exercício, você não deve utilizar o método Reverse.