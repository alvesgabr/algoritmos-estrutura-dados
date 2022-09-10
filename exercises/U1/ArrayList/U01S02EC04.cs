using System;
using System.Collections;

class U01S02EC04 {
  static public ArrayList CopyArray(ArrayList al){
    ArrayList copy = new ArrayList(al.Count);
    for (int i = 0; i < al.Count; i++){
      copy.Add(al[i]);
    }
    return copy;
  }
  static public void Main(string[] args){
    ArrayList al = new ArrayList();
    for (int n = 0; n < 8; n++){
      al.Add(Math.Abs((new Random()).Next()) % 100);
      ArrayList al2 = CopyArray(al);
      foreach (object o in al2)
      {
        Console.Write($"{o} ");
      }
    }
  }
}

// Faça o método public ArrayList CopiarArrayList(ArrayList origem) que copia todos os elementos do ArrayList origem e retorna um novo ArrayList. Neste exercício não é permitido o uso dos métodos Clone() nem CopyTo().