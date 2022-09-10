using System;
using System.Collections.Generic;

class U01S04EC08 {
  static void PrintD(Dictionary<int, string> og){
    foreach (KeyValuePair<int, string> kvp in og) {
      if(kvp.Key < 10){
        Console.WriteLine($"0{kvp.Key} = {kvp.Value}");
      } else {
        Console.WriteLine($"{kvp.Key} = {kvp.Value}");
      }
    }
  }
  static Dictionary<int, string> ConDict(Dictionary<int, string> d1, Dictionary<int, string> d2){
    Dictionary<int, string> temp = new Dictionary<int, string>();
    foreach(KeyValuePair<int, string> kvp in d1){
      temp.Add(kvp.Key, kvp.Value);
    }
    foreach(KeyValuePair<int, string> kvp in d2){
      temp.Add(kvp.Key, kvp.Value);
    }
    return temp;
  }
  static void Main(string[] args){
    Dictionary<int, string> d1 = new Dictionary<int, string>();
    Dictionary<int, string> d2 = new Dictionary<int, string>();

    string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

    for(int i = 0; i < (months.Length/2); i++){
      d1.Add((i+1), months[i]);
    }
    for(int i = 6; i < months.Length; i++){
      d2.Add((i+1), months[i]);
    }
    Dictionary<int, string> d3 = ConDict(d1, d2);
    PrintD(d3);
  }
}

// Faça o método public Dictionary <TKey,TValue> ConcatenaDictionary(Dictionary<TKey,TValue> d1, Dictionary<TKey,TValue> d2) que retorna um novo Dictionary<TKey,TValue> como todos os elementos de d1 e d2.