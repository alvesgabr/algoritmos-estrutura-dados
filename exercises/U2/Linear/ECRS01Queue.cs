using System;
using System.Collections;
using System.Collections.Generic;

class Lista {
  private int[] array;
  private int n;

  public Lista(){
    array = new int[6];
    n = 0;
  }

  public Lista(int cont){
    array = new int[cont];
    n = 0;
  }
  
// 7 - Modifique nossa lista linear, criando uma fila.
  public void Inserir(int x){
    if(n >= array.Length){
      Console.WriteLine("Invalid!");
      Environment.Exit(0);
    }
    for(int i = n; i > 0; i--){
      array[i] = array[i-1];
    }
    array[0] = x;
    n++;
  }

// 7 - Modifique nossa lista linear, criando uma fila.
  public int Remover(){
    if(n == 0){
      Console.WriteLine("Invalid!");
      Environment.Exit(0);
    }
    return array[--n];
  }

  public void Mostrar(){
    Console.Write("[ ");
    for(int i = 0; i < n; i++){
      Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
  }

  public bool Pesquisar(int x){
    bool temp = false;
    for(int i = 0; i < n && temp == false; i++){
      temp = (array[i] == x);
    }
    return temp;
  }

// 1 - Em nossa lista linear, implemente um método que retorna a soma dos elementos contidos na mesma. Done
  public int Soma(){
    int soma = 0;
    for(int i = 0; i < n; i++){
      soma += array[i];
    }
    return soma;
  }

// 2 - Em nossa lista linear, implemente um método que retorna o maior elemento contido na mesma. Done
  public int MaiorInt(){
    int temp = 0;
    for(int i = 0; i < n; i++){
      if(temp <= array[i]){
        temp = array[i];
      }
    }
    return temp;
  }
// 3 - Em nossa lista linear, implemente um método que inverte a ordem dos seus elementos. Done
  public void Inverter(){
    Stack temp = new Stack();
    for(int i = 0; i < n; i++){
      temp.Push(array[i]);
    }
    for(int i = 0; i < n; i++){
      array[i] = (int)temp.Pop();
    }
  }
// 4 - Em nossa lista linear, implemente um método que retorna o número de elementos pares and múltiplos de cinco contidos na mesma. Done
  public int ParesEMultiplos(){
    int cont = 0;
    for(int i = 0; i < n; i++){
      if((array[i] % 2 == 0) && (array[i] % 5 == 0)){
        cont++;
      }
    }
    return cont;
  }

// 5 - Modifique nossa lista linear, de tal forma que ela não tenha a referência último. WTF???????
// 6 - Modifique nossa lista linear, de tal forma que ela não tenha a referência último. WTF???????

}

class ECRS01Queue {
  static void Main(string[] args){
    Console.WriteLine("Linear:");
    Lista l = new Lista(6);
    int x1, x2, x3;

    l.Inserir(10);
    l.Inserir(7);
    l.Inserir(9);
    l.Inserir(3);
    l.Inserir(3);
    l.Inserir(2);

    int total = l.Soma();
    Console.WriteLine($"Soma total: {total}");

    int pares = l.ParesEMultiplos();
    Console.WriteLine($"Total de Pares e Multiplos de 5: {pares}");

    int maior = l.MaiorInt();
    Console.WriteLine($"Maior número: {maior}");

    Console.WriteLine("Antes:");
    l.Mostrar();

    l.Inverter();

    Console.WriteLine("Invertido:");
    l.Mostrar();

    x1 = l.Remover();
    x2 = l.Remover();
    x3 = l.Remover();

    Console.WriteLine($"Remoção: \n{x1}, {x2}, {x3}\nDepois:");
    l.Mostrar();
  }
}