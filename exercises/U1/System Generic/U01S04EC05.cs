using System;
using System.Collections.Generic;

class U01S04EC05 {
  static void PushEnd(Stack<int> og, int nu){
    Stack<int> temp = new Stack<int>();
    while(og.Count > 0){
      temp.Push(og.Pop());
    }
    temp.Push(nu);
    while(temp.Count > 0){
      og.Push(temp.Pop());
    }
  }
  static void Main(string[] args){
    Stack<int> s = new Stack<int>();
    for(int i = 0; i <= 20; i++){
      s.Push(i*2);
    }
    PushEnd(s, 999);
    Console.Write("Stack: ");
    foreach(int n in s){
      Console.Write($"{n} ");
    }
  }
}

// Faça o método public void VaiProFundo<T> (Stack<T> origem, T elemento) que empilha o elemento passado como parâmetro no fundo da Stack<T> origem, ao invés de empilhar no topo.