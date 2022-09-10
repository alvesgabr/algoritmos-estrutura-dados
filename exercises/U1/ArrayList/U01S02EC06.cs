using System;
using System.Collections;

class U01S02EC06 {
  static public void RemoveFromTo(ArrayList origin, int from, int to){
    int fromval = (from < to) ? from : to;
    int qtt = Math.Abs(to - from) + 1;
    for (int i = 0; fromval < origin.Count && i < qtt; i++){
      origin.RemoveAt(fromval);
    }
  }
  static public ArrayList CopyArray(ArrayList al){
    ArrayList copy = new ArrayList(al.Count);
    for (int i = 0; i < al.Count; i++){
      copy.Add(al[i]);
    }
    return copy;
  }

  public static void Main (string[] args) {
    ArrayList al = new ArrayList();
    for (int i = 0; i<=30;i++){
      al.Add(Math.Abs((new Random()).Next()) % 100);
    }
    ArrayList al2 = CopyArray(al);
    RemoveFromTo(al, 3, 16);
    Console.WriteLine("Array:");
    foreach(object o in al){
      Console.Write($"{o}, ");
    }
    Console.WriteLine();
    foreach (object o in al2){
      Console.Write($"{o}, ");
    }
  }
}

// Faça o método public void ApagarArrayList(ArrayList origem, int início, int final) que apaga todos os elementos no intervalo determinado pelos parâmetros início e final. Neste exercício não é permitido o uso do método RemoveRange(); use somente os métodos Remove() e RemoveAt(). Por exemplo, a chamada ApagarArrayList(al, 7, 10) apaga os elementos entre as posições 7 e 10.  