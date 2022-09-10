using System;
using System.Collections;

class U01S03EC01 {
  public static ArrayList CopytoArray(Queue q, ArrayList al){
    foreach (object o in q)
    {
      al.Add(o);
      Console.WriteLine($"{o} added to ArrayList");
    } return al;
  }
  public static void PrintQ(Queue q){
    foreach (object o in q)
    {
      Console.Write($"{o} ");
    }
  }
  public static void PrintAL(ArrayList al){
    foreach (object o in al)
    {
      Console.Write($"{o} ");
    }
  }
  public static void Main(string[] args){
    Queue q = new Queue();
    ArrayList al = new ArrayList();
    for (int i = 0; i <= 20; i++){
      q.Enqueue(i);
      Console.WriteLine($"{i} added\n");
    }
    CopytoArray(q, al);
    Console.WriteLine();
    PrintAL(al);
    Console.WriteLine();
    PrintQ(q);
  }
}
// Faça o método public ArrayList CopiarQueueParaArrayList(Queue origem) que copia todos os elementos do Queue origem e retorna um novo ArrayList. Neste exercício não é permitido o uso dos métodos Clone() nem CopyTo().