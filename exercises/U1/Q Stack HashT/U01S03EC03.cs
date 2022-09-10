using System;
using System.Collections;

class U01S03EC03 {
  public static Stack CopyStack(Stack og){
    Stack sh = new Stack(og.Count);
    Queue q = new Queue(og.Count);
    for (int i = og.Count; og.Count > 0; i--){
      q.Enqueue(og.Pop());
    }
    for (int i = q.Count; q.Count > 0; i--){
      og.Push(q.Peek());
      sh.Push(q.Dequeue());
    } return sh;

  }
  public static void Main(string[] args){
    Stack s = new Stack();
    for(int i = 0; i < 10; i++){
      s.Push(i);
    }
    Stack t = CopyStack(s);

    Console.WriteLine($"OG: ");
    foreach (int i in s){
      Console.Write($"{i} ");
    }

    Console.WriteLine($"\nTG: ");
    foreach (int i in t){
      Console.Write($"{i} ");
    }
  }
}
// Faça o método public Stack CopiarStack (Stack origem) que retorna uma cópia da Stack origem passada como parâmetro. Os elementos da Stack origem devem permanecer na mesma ordem original. Neste exercício não é permitido o uso dos métodos Clone() e CopyTo() da classe Stack.