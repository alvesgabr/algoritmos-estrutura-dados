using System;
using System.Collections;

class U01S02EC13 {
  static public ArrayList OccFrom(ArrayList al, Object el){
    ArrayList pos = new ArrayList();
    for (int i = 0; i < al.Count; i++){
      if (al[i].Equals(el)){
        pos.Add(i);
      }
    } return pos;
  }
  public static void Main(string[] args){
    ArrayList al = new ArrayList();
    for (int i = 0; i <= 30; i++){
      al.Add(Math.Abs((new Random()).Next()) % 5);
    }
    ArrayList pos = OccFrom(al, 2);
    Console.WriteLine("Array:");
    foreach(object o in pos){
      Console.Write($" {o} ");
    }
  }
}

// Faça o método public ArrayList OcorrenciasDe(ArrayList al, Object elemento) que recebe um ArrayList al e um Object elemento e retorna outro ArrayList contendo todas as posições em que o elemento aparece em al.