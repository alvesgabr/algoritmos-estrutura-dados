using System;
using System.Collections;
using System.Collections.Generic;

class U01S04EC03 {
  public static Queue CopyQ(Queue<int> og){
    return new Queue(og.ToArray());
  }
  public static void Main(string[] args){
    Queue<int> q =  new Queue<int>();
    for(int i = 0; i <= 20; i++){
      q.Enqueue(i*3);
    }
    Queue qq = CopyQ(q);
    Console.Write("Q: ");
    foreach(int n in qq){
      Console.Write($"{n} ");
    }
  }
}

// Faça o método public Queue CopiaQueue(Queue<int> origem) que copia todos os dados do Queue<int> origem e retorna o novo Queue (não genérico) criado.