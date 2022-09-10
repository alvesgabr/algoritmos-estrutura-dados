using System;
using System.Collections.Generic;

// gabarito 01 - linked lists

class U01S04GA01 {
  public static void Main(string[] args){
    LinkedList<string> meses = new LinkedList<string>();
    meses.AddLast("Mar");
    meses.AddLast("Jun");
    meses.AddLast("Jan");
    LinkedListNode<string> i = meses.Find("Mar");
    meses.AddBefore(i, "Fev");
    meses.AddAfter(i, "Abr");
    i = i.Next;
    meses.AddAfter(i, "Mai");
    meses.AddLast(new LinkedList<string>("Jul"));
    meses.AddFirst("Erro1");
    meses.AddLast("Erro2");
    meses.AddAfter(i, "Erro3");
    meses.RemoveFirst();
    meses.Remove("Erro3");
    foreach (string mes in meses){
      Console.WriteLine(mes);
    }
  }
}