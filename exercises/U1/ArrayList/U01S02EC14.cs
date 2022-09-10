using System;
using System.Collections;

class U01S02EC14 {
  static public int OccAmount(ArrayList  al, Object el){
    int cont = 0;
    for (int i = 0; i < al.Count; i++){
      if (al[i].Equals(el)){
        cont++;
      }
    } return cont;
  }
  public static void Main(string[] args){
    ArrayList al = new ArrayList();
    for (int i = 0; i <= 20; i++){
      al.Add(Math.Abs((new Random()).Next()) % 5);
    }
    int num = OccAmount(al, 2);
    Console.WriteLine($"Amount of #2s: {num}");
    Console.WriteLine("\nArray:");
    foreach(object o in al){
      Console.Write($"{o} ");
    }
  }
}

// Faça o método public int QtdeOcorrencias(ArrayList al, Object elemento) que retorna o número de vezes que o Object elemento aparece no ArrayList al.  