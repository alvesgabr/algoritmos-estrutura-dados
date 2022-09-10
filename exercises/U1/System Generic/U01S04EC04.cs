using System;
using System.Collections.Generic;

class U01S04EC04 {
  public static Stack<int> CopyS(Stack<int> og){
    return new Stack<int>(og);
  }
  public static void Main(string[] args){
    Stack<int> s = new Stack<int>();
    for(int i = 0; i <= 20; i++){
      s.Push((Math.Abs((new Random()).Next()) % 20));
    }
    Stack<int> ss = CopyS(s);
    Console.Write("Stack: ");
    foreach(int i in ss){
      Console.Write($"{i} ");
    }
  }
}

// Faça o método public Stack<T> CopiaStack<T> (Stack<T> origem) que retorna uma cópia da Stack<T> origem passada como parâmetro. Os elementos da Stack origem devem permanecer na mesma ordem original.