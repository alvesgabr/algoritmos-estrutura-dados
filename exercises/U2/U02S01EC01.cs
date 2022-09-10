using System;
using System.Collections;

class Fila{
  ArrayList arraylist;
  public Fila(){
    arraylist = new ArrayList();
  }
  public void Inserir(int i){
    arraylist.Add(i);
  }
  public int Remover(){
    int temp = (int)arraylist[0];
    arraylist.RemoveAt(0);
    return temp;
  }
  public void Mostrar(){
    foreach(int i in arraylist){
      Console.Write($"{i} ");
    }
  }
}
class U02S01EC01 {
  static void Main(string[] args){
    Fila f = new Fila();
    for(int i = 0; i < 10; i++){
      f.Inserir((Math.Abs((new Random()).Next())%100));
    }
    for(int i = 0; i < 3; i++){
      Console.Write($"Remvoing: {f.Remover()}\n");
      f.Inserir((10+i));  
    }
    Console.Write($"Print: \n");
    f.Mostrar();
  }
}

// Faça uma classe Fila contendo um atributo do tipo ArrayList, os métodos inserir, remover e mostrar os elementos da sua fila.
