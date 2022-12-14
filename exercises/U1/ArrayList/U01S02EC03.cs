using System;
using System.Collections;

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

class CompareSt : IComparer {
  public int Compare(Object o1, Object o2) {
    return ((Student)o1).name.CompareTo(((Student)o2).name);
  }
}

class U01S02EC03 {
  public static void Main (string[] args) {
    ArrayList al = new ArrayList();
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
        Console.WriteLine("Student ID:");
        al.Remove(Console.ReadLine());
      }else if (option == 3){
        Console.Write("Print:\n");
        foreach (object o in al){
          ((Student)o).Print();
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

// Fa??a um programa contendo um ArrayListque armazena Alunos (considere a classe Aluno apresentada nesta sess??o) e mostra as seguintes op????es de escolha para o usu??rio: 1 - inserir elemento; 2 - remover elemento; 3 - listar elementos; 4 - pesquisar elemento; 5 - ordenar elementos; e 6 - sair. Quando o usu??rio escolher uma das op????es, o programa realiza a opera????o escolhida no ArrayList.    