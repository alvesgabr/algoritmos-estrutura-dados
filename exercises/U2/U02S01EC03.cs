using System;
using System.Collections;

class Fila{
  Stack s;
  public Fila(){
    s = new Stack();
  }
  public void Enfileirar(int i){
    s.Push(i);
  }
  public int Remover(){
    Stack temp = new Stack();
    while(s.Count > 0){
      temp.Push(s.Pop());
    }
    int removido = (int)temp.Pop();
    while(temp.Count > 0){
      s.Push(temp.Pop());
    }
    return removido;
  }
  public void Mostrar(){
    Stack temp = new Stack();
    while(s.Count > 0){
      temp.Push(s.Pop());
    }
    foreach(int i in temp){
      Console.Write($"{i} ");
    }
  }
}
class U02S01EC03 {
  static void Main(string[] args){
    Fila f = new Fila();
    for(int i = 0; i < 10; i++){
      f.Enfileirar(i);
    }
    for(int i = 0; i < 3; i++){
      Console.Write($"Removing... {f.Remover()}\n");
      f.Enfileirar(i+10);
    }
    Console.Write("Print: ");
    f.Mostrar();
  }
}

// Faça uma classe Fila contendo dois atributos do tipo Stack, os métodos inserir, remover e mostrar os elementos da sua fila.
