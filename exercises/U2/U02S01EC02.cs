using System;
using System.Collections;

class Pilha{
  ArrayList al;
  public Pilha(){
    al = new ArrayList();
  }
  public void Empurrar(int i){
    al.Add(i);
  }
  public int Estourar(){
    int temp = (int)al[(al.Count-1)];
    al.RemoveAt((al.Count-1));
    return temp;
  }
  public void Mostrar(){
    foreach(int i in al){
      Console.Write($"{i} ");
    }
  }
}
class U02S01EC02 {
  static void Main(string[] args){
    Pilha p = new Pilha();
    for(int i = 0; i < 10; i++){
      p.Empurrar(i);
    }
    for(int i = 0; i < 3; i++){
      Console.Write($"Remvoing: {p.Estourar()}\n");
      p.Empurrar((10+i));  
    }
    Console.Write($"Print: \n");
    p.Mostrar();
  }
}

// Faça uma classe Pilha contendo um atributo do tipo ArrayList, os métodos inserir, remover e mostrar os elementos da sua pilha.