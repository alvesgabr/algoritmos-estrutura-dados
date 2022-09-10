using System;

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

  public void InserirInicio(int x){
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

  public void InserirFim(int x){
    if(n >= array.Length){
      Console.WriteLine("Invalid!");
      Environment.Exit(0);
    }
    array[n] = x;
    n++;
  }

  public void Inserir(int x, int pos){
    if(n >= array.Length || pos < 0 || pos > n){
      Console.WriteLine("Invalid!");
      Environment.Exit(0);
    }
    for(int i = n; i > pos; i--){
      array[i] = array[i-1];
    }
    array[pos] = x;
    n++;
  }

  public int RemoverInicio(){
    if(n == 0){
      Console.WriteLine("Invalid!");
      Environment.Exit(0);
    }
    int temp = array[0];
    n--;
    for(int i = 0; i < n; i++){
      array[i] = array[i+1];
    }
    return temp;
  }

  public int RemoverFim(){
    if(n == 0){
      Console.WriteLine("Invalid!");
      Environment.Exit(0);
    }
    return array[--n];
  }

  public int Remover(int pos){
    if(n == 0 || pos < 0 || pos >= n){
      Console.WriteLine("Invalid!");
      Environment.Exit(0);
    }
    int temp = array[pos];
    n--;
    for(int i = pos; i < n; i++){
      array[i] = array[i+1];
    }
    return temp;
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

}

class ECRS01 {
  static void Main(string[] args){
    Console.WriteLine("Linear:");
    Lista l = new Lista(6);
    int x1, x2, x3;

    l.InserirInicio(1);
    l.InserirFim(7);
    l.InserirFim(9);
    l.InserirInicio(3);
    l.Inserir(8, 3);
    l.Inserir(4, 2);

    Console.WriteLine("Antes:");
    l.Mostrar();

    x1 = l.RemoverInicio();
    x2 = l.RemoverFim();
    x3 = l.Remover(2);

    Console.WriteLine($"Remoção: \n{x1}, {x2}, {x3}\nDepois:");
    l.Mostrar();
  }
}