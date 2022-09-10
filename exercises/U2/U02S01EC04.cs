using System;
using System.Collections;

class Pilha
{
  Queue q;
  public Pilha()
  {
    q = new Queue();
  }
  public void Empurrar(int i){
    q.Enqueue(i);
  }
  public int Estourar(){
    Queue temp = new Queue();
    while(q.Count > 1){
      temp.Enqueue(q.Dequeue());
    }
    int del = (int)q.Dequeue();
    while(temp.Count > 0){
      q.Enqueue(temp.Dequeue());
    }
    return del;
  }
  public void Mostrar(){
    Stack temp = new Stack();
    while(q.Count > 0){
      temp.Push(q.Dequeue());
    }
    foreach(int i in temp){
      Console.Write($"{i} ");
    }
  }
}
class U02S01EC04 {
  static void Main(string[] args){
    Pilha p = new Pilha();
    for(int i = 0; i < 10; i++){
      p.Empurrar(i);
    }
    for(int i = 0; i < 5; i++){
      Console.WriteLine($"Removing... {p.Estourar()}");
      p.Empurrar(i+10);
    }
    Console.Write("Print: ");
    p.Mostrar();
  }
}

// Faça uma classe Pilha contendo dois atributos do tipo Queue, os métodos inserir, remover e mostrar os elementos da sua pilha.