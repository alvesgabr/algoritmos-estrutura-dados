using System;
using System.Collections.Generic;
class U01S04DC02 {
  public static void Main(string[] args){
    // new dict String + dict String , Integers - disciplinaNotas : Aluno - Nota
    Dictionary<string, Dictionary<string, int>> notas = new Dictionary<string, Dictionary<string, int>>();

    // list of students and a randomizer for their grades
    string[] alunos = {"João", "Maria", "Joaquim", "Lucas", "Anna", "Carla"};
    notas.Add("AED", new Dictionary<string, int>());
    for(int i = 0; i < alunos.Length; i++){
      notas["AED"].Add(alunos[i], (Math.Abs((new Random()).Next()) % 100));
    }

    // same as line 7
    string[] novosAlunos = {"David", "Liam", "Noah", "Charlie", "Adam", "Susan"};
    notas.Add("Calculo", new Dictionary<string, int>());
    for(int i = 0; i < novosAlunos.Length; i++){
      notas["Calculo"].Add(novosAlunos[i], (Math.Abs((new Random()).Next()) % 100));
    }

    // this is fun, it uses var 'disciplina' to manipulate the data in notas dict
    // so each notas.Key is a discipline, and each notas.Value is a dict full of students data
    // disciplina.Key = notas.Key = AED or Calculo
    // Aluno in disciplina.Value = notas.Value = dict<string, int> = Alunos < NAME, GRADE > = { (João, 99), (Maria, 99) }
    // Aluno.Key = Names, Aluno.Value = grade, bc its the dictionary data, after that its just an avg calc
    foreach(KeyValuePair<string, Dictionary<string, int>> disciplina in notas){
      Console.WriteLine(disciplina.Key);
      Console.WriteLine("\tAlunos:");
      double media = 0;
      foreach(KeyValuePair<string, int> Aluno in disciplina.Value) {
        Console.WriteLine($"\t\tAluno: {Aluno.Key} \t- Nota: {Aluno.Value}");
        media += Aluno.Value;
      }
      
      media /= disciplina.Value.Count;
      Console.WriteLine($"\n\tMédia = {media}");
      Console.WriteLine();
    }
  }
}