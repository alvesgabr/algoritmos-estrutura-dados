using System;
using System.Collections;
class U01S03EC05{
  static public void Inverter(Queue q){
    Stack s = new Stack(q.Count);
    while(q.Count > 0){
      s.Push(q.Dequeue());
    }
    while(s.Count > 0){
      q.Enqueue(s.Pop());
    }
  }
  public static void Main(string[] args){
    Queue q = new Queue();
    for(int i = 0; i < 10; i++){
      q.Enqueue(i);
    }
    Console.WriteLine("B: ");
    foreach(int i in q){
      Console.Write($"{i} ");
    }
    Inverter(q);
    Console.WriteLine("\nA: ");
    foreach(int i in q){
      Console.Write($"{i} ");
    }
  }
}
// Faça o método public void InverterQueue(Queue q) que inverte a ordem dos elementos do Queue q, no próprio Queue. Neste exercício, se necessário, utilize estruturas auxiliares (array, ArrayList, Stack ou mesmo outro Queue). Contudo, não é permitido o uso do método Reverse().