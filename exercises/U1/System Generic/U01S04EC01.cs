using System;
using System.Collections.Generic;

class U01S04EC01 {
  public static int Occurrences(List<string> og, String value){
    int i = 0;
    foreach (string s in og)
    {
      if(s.Equals(value) == true){
        i++;
      }
    } return i;
  }
  public static void Main(string[] args){
    String s = "aaa";
    List<string> list = new List<string>();
    string[] l = {"aaa", "bbb", "ccc", "ddd", "eee"};
    List<string> verification = new List<string>();
    for(int i = 0; i < (l.Length * 3); i++){
      int randomizer = Math.Abs((new Random()).Next()) % l.Length;
      list.Add(l[randomizer]);
      verification.Add(l[randomizer]);
    }
    Console.WriteLine($"# de ocorrências: {Occurrences(list, s)}\n");
    foreach(string ss in verification){
      if(ss == s) {
        Console.WriteLine($"{ss} - I'm HERE!");
      } else
      {
        Console.WriteLine($"{ss}");
      }
    }
  }
}

// Faça o método public int QtdeOcorrencias(List<String> origem, String elemento) que retorna a quantidade de vezes que o elemento passado como parâmetro está armazenado no List<String> origem.