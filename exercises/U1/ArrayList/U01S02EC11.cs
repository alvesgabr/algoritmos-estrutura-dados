using System;
using System.Collections;

class U01S02EC11 {
  public static ArrayList Unite(ArrayList al1, ArrayList al2){
    ArrayList united = new ArrayList(al1.Count + al2.Count);
    foreach(object o in al1){
      if (united.Contains(o) == false){
        united.Add(o);
      }
    } foreach (object o in al2){
      if (united.Contains(o) == false){
        united.Add(o);
      }
    } return united;
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
    ArrayList al3 = Unite(al1, al2);
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

// Faça o método public ArrayList Uniao(ArrayListal1, ArrayListal2) que recebe dois ArrayLists e retorna outro contendo todos os elementos armazenados em al1 e al2, sem repetição. 