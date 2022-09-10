using System;
using System.Collections;
class U01S03EC07{
  public static Hashtable ConcatenateHash(Hashtable h1, Hashtable h2){
    Hashtable sh = new Hashtable();
    foreach(DictionaryEntry de in h1){
      sh.Add(de.Key, de.Value);
    }
    foreach(DictionaryEntry de in h2){
      sh.Add(de.Key, de.Value);
    } return sh;
  }
  public static void Main(string[] args){
    Hashtable h1 = new Hashtable();
    Hashtable h2 = new Hashtable();

    for(int i = 0; i < 10; i++){
      h1.Add(i, i*10);
      h2.Add((i+10), ((i+10)*10));
    }

    Hashtable final = ConcatenateHash(h1, h2);

    foreach(DictionaryEntry de in final){
      Console.WriteLine($"Key {de.Key} - Value: {de.Value}");
    }
  }
}
// Faça o método public Hashtable ConcatenarHashtable(Hashtable ht1, Hashtable th2) que retorna um novo Hashtable contendo todos os elementos de ht1 e ht2.