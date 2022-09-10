using System;
using System.Collections;

class U01S02EC09 {
  static public ArrayList ConcatenateAL(ArrayList al1, ArrayList al2, ArrayList al3) {
    ArrayList final = new ArrayList(al1.Count + al2.Count + al3.Count);
    for (int i = 0; i < al1.Count; i++){
      final.Add(al1[i]);
    }
    for (int i = 0; i < al2.Count; i++){
      final.Add(al2[i]);
    }
    for ( int i = 0; i < al3.Count; i++){
      final.Add(al3[i]);
    }
    return final;
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
    ArrayList al3 = new ArrayList();
     for (int i = 0; i<=10;i++){
      al3.Add(Math.Abs((new Random()).Next()) % 100);
    }  
    ArrayList final = ConcatenateAL(al1 , al2, al3);

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

    Console.WriteLine("\nFinal Array:");
    foreach(object o in final){
      Console.Write($"{o}, ");
    }
  }
}

// Faça o método public void ConcatenaArrayList2(ArrayList al1, ArrayList al2, ArrayList al3) que recebe três objetos ArrayList al1, al2 e al3, concatena os todos os elementos de al1 e al2 em al3. Por exemplo, se os valores dos dois primeiros ArrayLists passados por parâmetro forem [19, 33, 2, 4] e [1, 2, 3, 4, 5], o valor final de al3 será [19, 33, 2, 4, 1, 2, 3, 4, 5].