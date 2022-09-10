using System;
using System.Collections;

class U01S02EC05 {
  static public ArrayList CopyFromTo(ArrayList origin, int from, int to){
    ArrayList copy = new ArrayList(Math.Abs(from - to)+1);
    if (from < to) {
      for (int i = from; i < origin.Count && i <= to; i++){
        copy.Add(origin[i]);
      }
    } else if (to < from) {
      for (int i = to; i >= 0 && i >= from; i++){
        copy.Add(origin[i]);
      }
    } return copy;
  }

  public static void Main (string[] args) {
    ArrayList al = new ArrayList();
    for (int i = 0; i<=10;i++){
      al.Add(Math.Abs((new Random()).Next()) % 20);
    }
    ArrayList la = CopyFromTo(al, 2, 6);
    Console.WriteLine("Array:");
    foreach(object o in la){
      Console.Write($" {o},");
    }
  }
}

// Faça o método public ArrayList CopiarParteArrayList(ArrayList origem, int início, int final) que recebe um ArrayList origem e os inteiros início e final e retorna outro ArrayList contendo todos os elementos dentro do intervalo determinado pelos parâmetros início e final. Se o ArrayList origem tiver menos posições do que determinado pelo parâmetro final, copie até a sua última posição. Se o parâmetro início for maior que a quantidade de elementos do ArrayList origem, retorne um ArrayList vazio. Por fim, se o parâmetro início for maior que o parâmetro final, indique que o usuário deseja copiar os dados na ordem invertida. Neste exercício não é permitido o uso dos métodos Clone() nem CopyTo().