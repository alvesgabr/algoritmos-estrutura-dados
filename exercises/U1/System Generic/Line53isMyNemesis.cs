using System;
using System.Collections.Generic;

class Student {
  public int id;
  public string name, email;
  public Student() {
    this.name = "";
    this.email = "";
    this.id = 0;
  }
  public Student(string name, int id, string email) {
    this.name = name;
    this.email = email;
    this.id = id;
  }
  public void Print(){
    Console.WriteLine($"ID: {id}\nAluno: {name} - {email}\n");
  }
}

class CompareSt : IComparer<Student> {
  public int Compare(Student sa, Student sb) {
    return sa.name.CompareTo(sb.name);
  }
}

class U01S02EC03 {
  public static void Main (string[] args) {
    List<Student> al = new List<Student>();
    int option;

    do {
      Console.WriteLine("Choose an option:");
      Console.WriteLine("1 - Insert");
      Console.WriteLine("2 - Remove");
      Console.WriteLine("3 - Print");
      Console.WriteLine("4 - Search");
      Console.WriteLine("5 - Sort");
      Console.WriteLine("6 - Exit");
      option = int.Parse(Console.ReadLine());
      if (option == 1){
        Student st = new Student();
        Console.WriteLine("Name:");
        st.name = Console.ReadLine();
        Console.WriteLine("ID:");
        st.id = int.Parse(Console.ReadLine());
        Console.WriteLine("Emai:");
        st.email = Console.ReadLine();
        al.Add(st);
      }else if (option == 2){
        Console.WriteLine("Student Index:");
        // the idea here was to use the Student ID to identify it
        // in the list, but i was too stupid to figure it out
        // kinda still am tho, but what ended up working was
        // to use the index, so it aint much, but its honest work
        al.RemoveAt(int.Parse(Console.ReadLine()));
      }else if (option == 3){
        Console.Write("Print:\n");
        foreach (Student s in al){
          s.Print();
        }
      }else if (option == 4){
        Console.WriteLine("Student Name:");
        string search = Console.ReadLine();
        al.Sort(new CompareSt());
        int pos = al.BinarySearch(new Student(search, 0, ""), new CompareSt());
        Console.WriteLine($"Contains {search}: {pos>=0}");
      }else if (option == 5){
        al.Sort(new CompareSt());
        Console.WriteLine("Sorted");
      }else if (option == 6){
        Console.WriteLine("End");
      }else {
        Console.WriteLine("Invalid");
      }
    } while (option != 6);
  }
}

// Faça um programa contendo um ArrayListque armazena Alunos (considere a classe Aluno apresentada nesta sessão) e mostra as seguintes opções de escolha para o usuário: 1 - inserir elemento; 2 - remover elemento; 3 - listar elementos; 4 - pesquisar elemento; 5 - ordenar elementos; e 6 - sair. Quando o usuário escolher uma das opções, o programa realiza a operação escolhida no ArrayList.    