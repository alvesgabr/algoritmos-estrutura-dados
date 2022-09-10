using System;
using System.Collections;

class U01S03HT01 {
  public static void Main(string[] args){
    //#table creation
    Hashtable h = new Hashtable();
    //key #, value Name being added
    h.Add(1,"John");
    h.Add(2,"Lisa");
    h.Add(3,"Dave");
    //boolean if contains smthin @ k1 and how many values exists
    //op contains: true - count: 3
    Console.WriteLine($"Contains: {h.Contains(1)} - Count: {h.Count}");
    //boolean if key 1 exists - op true
    Console.WriteLine(h.ContainsKey(1));
    //boolean if it contains value john - op contains john? true
    Console.WriteLine($"Contains John? {h.ContainsValue("John")}");
    //removing key 1, aka john
    h.Remove(1);
    //boolean if it contains value john - op contains john? false
    Console.WriteLine($"Contains John? {h.ContainsValue("John")}");
  }
}