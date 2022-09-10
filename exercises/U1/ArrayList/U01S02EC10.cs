using System;
using System.Collections;

class U01S02EC10 {
  static public ArrayList Intersec(ArrayList al1, ArrayList al2){
    ArrayList intersec = new ArrayList();
    foreach (object o in al1)
    {
      if (al2.Contains(o) && !intersec.Contains(o)){
        intersec.Add(o);
      }
    } return intersec;
  }
  public static void Main(string[] args){
    ArrayList al1 = new ArrayList();
    for (int i = 0; i <= 30; i++){
      al1.Add(Math.Abs((new Random()).Next()) % 100);
    }
    ArrayList al2 = new ArrayList();
    for (int i = 0; i <= 30; i++){
      al2.Add(Math.Abs((new Random()).Next()) % 100);
    }
    ArrayList al3 = Intersec(al1, al2);
    Console.WriteLine("\nArray 1:");
    foreach(object o in al1){
      Console.Write($"{o} ");
    }
    Console.WriteLine("\nArray 2:");
    foreach(object o in al2){
      Console.Write($"{o} ");
    }
    Console.WriteLine("\nArray 3:");
    foreach(object o in al3){
      Console.Write($"{o} ");
    }
  }
}

// Faça o método public ArrayList Intersecao(ArrayList al1, ArrayList al2) que recebe dois ArrayLists e retorna outro contendo os elementos em comum armazenados em al1 e al2, sem repetição.