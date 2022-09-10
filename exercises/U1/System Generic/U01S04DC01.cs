using System;
using System.Collections.Generic;

class U01S04DC01 {
  public static void Main(string[] args){
    // new dictionary (integers, strings)
    Dictionary<int, string> dc = new Dictionary<int, string>();

    // list of months to use in the dict
    string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

    // add all months with apropriate numbers for later
    for(int i = 0; i < months.Length; i++){
      // add i+1 = 1, 2, 3... with index i++ = 0++ of months, Jan, Feb...
      dc.Add((i+1), months[i]);
    }

    // basic print
    foreach (KeyValuePair<int, string> kvp in dc) {
      if(kvp.Key < 10){
        Console.WriteLine($"0{kvp.Key} = {kvp.Value}");
      } else {
        Console.WriteLine($"{kvp.Key} = {kvp.Value}");
      }
    }
    Console.WriteLine("\nMonths successfully added.");

    // just using .Keys and .Values, i guess you cannot invert them
    Dictionary<int, string>.KeyCollection dK = dc.Keys;
    Console.Write("Keys: ");
    foreach(int k in dc.Keys){
      Console.Write($"{k} ");
    }

    Dictionary<int, string>.ValueCollection dV = dc.Values;
    Console.Write("\nValues: ");
    foreach(string s in dc.Values){
      Console.Write($"{s} ");
    }
    Console.WriteLine();    

    // i wanted to use lines 25 and 30 to invert keys with values 
    // but it doesnt compile, so heres my loop, its just practice
    // i couldve just inverted the order when doing a wl, but meh,
    // this is rather fun and its 20h  ¯\_(ツ)_/¯
    Dictionary<string, int> nary = new Dictionary<string, int>(dc.Count);
    for(int n = 0; n < dc.Count;n++){
      string abracadabra = "";
      dc.TryGetValue((n+1), out abracadabra);
      nary.Add(abracadabra, (n+1));
    }
    Console.WriteLine();

    // basic print
    foreach (KeyValuePair<string, int> kvp in nary) {
      if(kvp.Value < 10){
        Console.WriteLine($"{kvp.Key} = 0{kvp.Value}");
      } else {
        Console.WriteLine($"{kvp.Key} = {kvp.Value}");
      }
    }

    // basic remove key 4 = apr
    dc.Remove(4);
    Console.WriteLine($"\nApril Removed!");

    // using ContainsKey(), output True
    Console.WriteLine($"Checking Key 3: {dc.ContainsKey(3)}!");

    // ContainsValue(), output False bc of line 17
    Console.WriteLine($"Checking April: {dc.ContainsValue("Apr")}!");

    // TryGetValue(TKey, out TValue), bool method, if T - it returns the key's value to 'value', nothing if F, output is Nov
    string value = "";
    dc.TryGetValue(11, out value);
    Console.WriteLine($"Month 11 is: {value}!");
    
    // output is False
    Console.WriteLine($"Trying value of K4: {dc.TryGetValue(4, out value)}!");
    
    // basic clear()
    dc.Clear();
    nary.Clear();
    Console.WriteLine("\nData wiped!");
  }
}