using System;
using System.Collections;

class Car {
  public int year;
  public string model, brand;

  public Car() {
    this.model = "";
    this.brand = "";
    this.year = 0;
  }
  public Car(string model, int year, string brand) {
    this.model = model;
    this.year = year;
    this.brand = brand;
  }
  public void PrintCar() {
    Console.WriteLine($"\nCar Model: {model} - Year {year}\nBrand: {brand}");
  }
}
class CompareCar : IComparer {
  public int Compare(Object o1, Object o2){
    return ((Car)o1).model.CompareTo(((Car)o2).model);
  }
}
class SyntaxMemo {
  public static void Print(ArrayList cl) {
    Console.WriteLine("List of cars:");
    foreach (object o in cl){
      ((Car)o).PrintCar();
    }
  }
  public static void Main (string[] args) {
    ArrayList cl = new ArrayList();
    int option;
    Console.WriteLine("### CarMotors System ###");
    do {
      Console.WriteLine("\nChoose an option:");
      Console.Write(" 1 - Insert ");
      Console.Write(" 2 - Remove ");
      Console.Write(" 3 - Print ");
      Console.Write(" 4 - Search ");
      Console.Write(" 5 - Sort ");
      Console.Write(" 6 - Exit\n ");
      option = int.Parse(Console.ReadLine());
      if (option == 1) {
        Car cr = new Car();
        Console.WriteLine("Model:");
        cr.model = Console.ReadLine();
        Console.WriteLine("Brand:");
        cr.brand = Console.ReadLine();
        Console.WriteLine("Year:");
        cr.year = int.Parse(Console.ReadLine());
        cl.Add(cr);
      }else if (option == 2) {
        Console.WriteLine("Car Model");
        cl.Remove(Console.ReadLine());
      }else if (option == 3) {
        Console.Write("\nList:\n");
        foreach (object c in cl){
          ((Car)c).PrintCar();
        }
      }else if (option == 4) {
        Car c = (Car)cl[Math.Abs((new Random()).Next()) % cl.Count];
        int pos = cl.BinarySearch(c, new CompareCar());
        Console.WriteLine($"Pos {pos}: Model: {c.model}");
        c.model = "Corolla";
        pos = cl.BinarySearch(c, new CompareCar());
        Console.WriteLine($"Pos {pos}: Model: {c.model}");
      }else if (option == 5) {
        cl.Sort(new CompareCar());
        Console.WriteLine("Done");
      }else if (option == 6) {
        Console.WriteLine("END");
      }else {
        Console.WriteLine("Invalid!");
      }
    } while (option != 6);
  }
}