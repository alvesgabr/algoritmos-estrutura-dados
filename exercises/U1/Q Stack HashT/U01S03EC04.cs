using System;
using System.Collections;

class U01S03EC04 {
  static public void PushEnd(Stack og, Object el){
    Stack aux = new Stack(og.Count);
    int amt = og.Count;
    for(int i = 0; i < amt; i++){
      aux.Push(og.Pop());
    }
    og.Push(el);
    for(int i = 0; i < amt; i++){
      og.Push(aux.Pop());
    }
  }
  
  public static void Main(string[] args){
    Stack s = new Stack();
    for(int i = 0; i < 10; i++){
      PushEnd(s, i);
    }

    do {
      Console.WriteLine(s.Pop());
    } while(s.Count > 0);
  }
}
// Faça o método public void VaiProFundo(Stack origem, Object elemento) que empilha o elemento passado como parâmetro no fundo da Stack, ao invés de no topo.