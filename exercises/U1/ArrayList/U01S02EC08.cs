using System;
using System.Collections;

class U01S02EC08 {
  static public ArrayList ConcatenateAL(ArrayList al1, ArrayList al2) {
    ArrayList al3 = new ArrayList(al1.Count + al2.Count);
    for (int i = 0; i < al1.Count; i++){
      al3.Add(al1[i]);
    }
    for (int i = 0; i < al2.Count; i++){
      al3.Add(al2[i]);
    }
    return al3;
  }

  public static void Main (string[] args) {
    ArrayList al1 = new ArrayList();
    for (int i = 0; i<=10;i++){
      al1.Add(Math.Abs((new Random()).Next()) % 100);
    }
    ArrayList al2 = new ArrayList();
    for (int i = 0; i<=10;i++){
      al2.Add(Math.Abs((new Random()).Next()) % 100);
    }
    ArrayList al3 = ConcatenateAL(al1 , al2);
    Console.WriteLine("\nArray 1:");
    foreach(object o in al1){
      Console.Write($"{o}, ");
    }
    Console.WriteLine("\nArray 2:");
    foreach(object o in al2){
      Console.Write($"{o}, ");
    }
    Console.WriteLine("\nArray 3:");
    foreach(object o in al3){
      Console.Write($"{o}, ");
    }
  }
}

// Faça o método public ArrayList ConcatenaArrayList(ArrayList al1, ArrayList al2) que recebe dois objetos ArrayList al1 e al2 e retorna outro ArrayList concatenando todos os elementos de al1 e al2. Por exemplo, se os valores dos dois ArrayLists passados por parâmetro forem [19, 33, 2, 4] e [1, 2, 3, 4, 5], o ArrayList retornado será [19, 33, 2, 4, 1, 2, 3, 4, 5].    