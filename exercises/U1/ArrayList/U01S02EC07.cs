using System;
using System.Collections;

class U01S02EC07 {
  static public void RemoveFromTo(ArrayList origin, int from, int amount){
    for (int i = 0; from < origin.Count && i < amount; i++){
      origin.RemoveAt(from);
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

// Faça o método public void ApagarArrayList2(ArrayList origem, int início, int qtde) que apaga todos os qtde elementos a partir da posição determinada pelo parâmetro início. Neste exercício não é permitido o uso do método RemoveRange(); use somente os métodos Remove() e RemoveAt(). Por exemplo, a chamada ApagarArrayList2(al, 7, 5) apaga 5 elementos a partir da posição 7, ou seja, os elementos das posições 7, 8, 9, 10 e 11.