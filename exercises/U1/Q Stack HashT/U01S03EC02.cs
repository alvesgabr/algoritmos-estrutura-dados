using System;
using System.Collections;

class U01S03EC02 {
  static public Queue CopyQ(Queue q){
    Queue sh = new Queue(q.Count);
    for(int i=0;i<q.Count;i++){
      sh.Enqueue(q.Peek());
      q.Enqueue(q.Dequeue());
    } return sh;
  }
  public static void Main(string[] args){
    Queue q = new Queue();
    for (int i = 0; i < 10; i++){
      q.Enqueue(i);
    }

    Queue d = CopyQ(q);

    Console.Write($"\nQ: ");
    foreach(object o in q){
      Console.Write($"{o} ");
    }

    Console.Write($"\nD: ");
    foreach(object o in d){
      Console.Write($"{o} ");
    }    
  }
}
// Faça o método public Queue CopiarQueue(Queue origem) que retorna uma cópia da Queue origem passada como parâmetro. Os elementos da Queue origem devem permanecer na mesma ordem original. Neste exercício é permitido o uso dos métodos Clone() e CopyTo() da classe Queue.