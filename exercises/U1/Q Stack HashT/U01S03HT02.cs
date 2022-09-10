using System;
using System.Collections;

class U01S03HT02 {
  public static void Main(string[] args){
    Hashtable h = new Hashtable();

    // Insere os pares chave/valor 1/10 -> 5/50
    for (int i = 1; i <= 5; i++){
      h.Add(i,(i*10));
      Console.Write($"Key: #{i} - Value: {(i*10)} added.\n");
    }

    // Mostra o número de elementos na table
    Console.WriteLine($"Amount of elements: {h.Count}.");

    // Remove o elemento com chave 1
    h.Remove(1);
    Console.WriteLine($"Contains 1: {h.Contains(1)}");

    // Escreve y/n se existir um objeto com chave 1
    if (h.ContainsKey(1) == true){
      Console.WriteLine($"Key 1 found!");
    } else {
      Console.WriteLine($"Key 1 not found!");
    }

    // Escreve y/n se existir um objeto com chave 5
    if (h.Contains(5) == true) {
      Console.WriteLine($"Key 5 found!");
    } else {
      Console.WriteLine($"Key 5 not found!");
    }

    // Insere os pares chave/valor 6/60 -> 10/100
    for ( int i = 6; i <= 10; i++){
      h.Add(i,(i*10));
      Console.Write($"Key: #{i} - Value: {(i*10)} added.\n");
    }

    // Remove e mostra os elementos com as chaves 5 e 8
    h.Remove(5);
    Console.WriteLine($"Contains 5: {h.Contains(5)}");
    h.Remove(8);
    Console.WriteLine($"Contains 8: {h.Contains(8)}");

    // Limpa a estrutura e mostra o número de elementos existentes
    h.Clear();
    Console.WriteLine($"Amount of elements: {h.Count}.");
  }
}