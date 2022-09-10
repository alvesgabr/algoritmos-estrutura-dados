using System;
using System.Collections.Generic;

class U01S04EC02 {
  public static void WipeQ(Queue<int> og, int from, int to){
    if(from > to){
      Console.WriteLine("Invalid");
    } else if(to >= og.Count){
      Console.WriteLine("Invalid");
    } else {
      int size = og.Count;
      for(int i = 0; i < from; i++){
        og.Enqueue(og.Dequeue());
      } for(int i = from; i <= to; i++){
        og.Dequeue();
      } for(int i = to + 1; i < size; i++){
        og.Enqueue(og.Dequeue());
      }
    }
  }
  public static void Main(string[] args){
    Queue<int> q = new Queue<int>();
    for(int i = 0; i <= 20; i++){
      q.Enqueue(i*10);
    }
    WipeQ(q, 7, 10);

    Console.Write("Q: ");
    foreach (int i in q){
     Console.Write($"{i} ") ;
    } Console.WriteLine();
  }
}

// Faça o método public void ApagaQueue(Queue<int> origem, int início, int final) que apaga todos os elementos no intervalo determinado pelos parâmetros início e final. Por exemplo, ApagaQueue(q, 7, 10) => apaga os elementos entre as posições 7 e 10.