using System;
using System.Collections;

class U01S02EC12 {
  static void RepetitionRemover(ArrayList al){
    int p1 = 0;
    while (p1 < al.Count){
      int p2 = al.LastIndexOf(al[p1]);
      while (p1 != p2){
        al.RemoveAt(p2);
        p2 = al.LastIndexOf(al[p1]);
      } p1++;
    }
  }
  static public ArrayList CopyArray(ArrayList al){
    ArrayList copy = new ArrayList(al.Count);
    for (int i = 0; i < al.Count; i++){
      copy.Add(al[i]);
    }
    return copy;
  }
  public static void Main(string[] args){
    ArrayList al = new ArrayList();
    for (int i = 0; i <= 30; i++){
      al.Add(Math.Abs((new Random()).Next()) % 100);
    }
    ArrayList al2 = CopyArray(al);
    RepetitionRemover(al);

    Console.WriteLine("\nArray Clean:");
    foreach(object o in al){
      Console.Write($"{o} ");
    }
    Console.WriteLine("\nArray Full:");
    foreach(object o in al2){
      Console.Write($"{o} ");
    }
  }
}

// Faça o método public void ApagaRepetidos(ArrayList al) que recebe um ArrayList e apaga todas as ocorrências repetidas, mantendo apenas a primeira ocorrência de cada elemento.