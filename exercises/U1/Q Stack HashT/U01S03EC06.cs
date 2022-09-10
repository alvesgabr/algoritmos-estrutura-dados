using System;
using System.Collections;
class U01S03EC06{
  public static void Inverter(Stack s){
    Queue q = new Queue(s.Count);
    while(s.Count > 0){
      q.Enqueue(s.Pop());
    }
    while(q.Count > 0){
      s.Push(q.Dequeue());
    }
  }
  public static void Main(string[] args){
    Stack s = new Stack();
    for(int i = 0; i < 10; i++){
      s.Push(i);
    }
    Console.WriteLine("B: ");
    foreach(int i in s){
      Console.Write($"{i} ");
    }
    Inverter(s);
    Console.WriteLine("\nA: ");
    foreach(int i in s){
      Console.Write($"{i} ");
    }
  }
}
// Faça o método public void InverterStack(Stack s) que inverte a ordem dos elementos do Stack s, no próprio Stack.. Neste exercício, se necessário, utilize estruturas auxiliares (array, ArrayList, Stack ou Queue). Contudo, não é permitido o uso do método Reverse().