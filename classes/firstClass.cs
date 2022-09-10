using System;
using System.Collections;

// First Introduction to C# Collections, ArrayList in this case

class mainCode{
   // Print ArrayList
   public static void Print(ArrayList myAL)
   {
      Console.Write("ArrayList:");
      foreach (object o in myAL)
      {
         Console.Write(o + " ");
         // convert obj to student - nt#2 
         // ((Student)o).Print();
      }
      Console.WriteLine();
   }

   // Print Array
   public static void Print(Object[] vetor)
   {
      Console.Write("Object[]:");
      foreach (object o in vetor)
      {
         Console.Write(o + " ");
      }
      Console.WriteLine();
   }

   // Main
   public static void Main (string[] args)
   {
      ArrayList myAL = new ArrayList();

      // Adding
      Console.WriteLine("\n# ------------------- Add");
      myAL.Add(34);
      myAL.Add(4.33);
      myAL.Add("String");
      myAL.Insert(3, 394); //394 @index 3
      myAL.Add(1);
      myAL.Add(2);
      myAL.Add(3);
      myAL.Add(4);
      Print(myAL);

      // Printing
      Console.WriteLine("\n# ------------------- Print:");
      Console.WriteLine($"AL[0] {myAL[0]}");
      Console.WriteLine($"AL[1] {myAL[1]}");
      Console.WriteLine($"AL[2] {myAL[2]}");
      Console.WriteLine($"AL[3] {myAL[3]}");

      // Removing
      Console.WriteLine("\n# ------------------- Remove");
      myAL.Remove(4.33);
      myAL.RemoveAt(1);
      myAL.RemoveRange(0,2);
      Print(myAL);

      // Clear ArrayList
      Console.WriteLine("\n# ------------------- Clear");
      myAL.Clear();
      Console.WriteLine($"Capacity: {myAL.Capacity} | Count: {myAL.Count}");

      // Contains 2 || 9
      Console.WriteLine("\n# ------------------- Contains");
      for(int i = 0; i<20; i++){
         myAL.Add(i*2/* nt#1 */);
      }
      if (myAL.Contains(2) == true)
      {
         Console.WriteLine("Element 2 found!");
      } else {
         Console.WriteLine("Element 2 not found!");
      }
      if (myAL.Contains(9) == true)
      {
         Console.WriteLine("Element 9 found!");
      } else {
         Console.WriteLine("Element 9 not found!");
      }

      // IndexOf 2
      Console.WriteLine("\n# ------------------- IndexOf");
      myAL.Add(2);
      Console.WriteLine($"IndexOf(2): {myAL.IndexOf(2)}");
      Console.WriteLine($"LastIndexOf(2): {myAL.LastIndexOf(2)}");

      // Reverse
      Console.WriteLine("\n# ------------------- Reverse");
      Print(myAL);
      myAL.Reverse();
      Print(myAL);
      myAL.Reverse(3,5); //5 eles reversed, @index 3 onward
      Print(myAL);

      // Sort
      Console.WriteLine("\n# ------------------- Sort");
      myAL.Sort();
      Print(myAL);

      // ToArray
      Console.WriteLine("\n# ------------------- ToArray");
      Object[] vetor = myAL.ToArray();
      Print(vetor);

      // TrimeToSize
      Console.WriteLine("\n# ------------------- TrimToSize");
      Console.Write($"Capacity: {myAL.Capacity} | Count: {myAL.Count}\n");
      myAL.TrimToSize();
      Console.Write($"Capacity: {myAL.Capacity} | Count: {myAL.Count}\n");

      // BinarySearch 2 && 9
      Console.WriteLine("\n# ------------------- BinarySearch");
      int pos = myAL.BinarySearch(2);
      Console.WriteLine($"#2 Pos: {pos}");
      pos = myAL.BinarySearch(9);
      Console.WriteLine($"#9 Pos: {pos}");
   }
}

/*
Notes #1:
Math.Abs((new Random()).Next()) % 100;
> absolute random # between 0 and 100

Notes #2:
class Student
{
   public int id;
   public string name, email;

   null Constructor
   public Student()
   {
      this.name = "";
      this.email = "";
      this.id = 0;
   }

   Constructor with values
   public Student(string name, int id, string email)
   {
      this.name = name;
      this.email = email;
      this.id = id;
   }

   public void Print()
   {
      Console.WriteLine(name + " (id " + id + ") -- " + email);
   }
}
*/ 