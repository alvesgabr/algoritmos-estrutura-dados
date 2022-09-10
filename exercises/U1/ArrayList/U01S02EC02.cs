using System;
using System.Collections;

class U01S02EC02 {
  public static void Main (string[] args){
    ArrayList al = new ArrayList();
    int opcao;
    do {
      Console.WriteLine("Digite uma opção:");
      Console.WriteLine("1 - inserir elemento");
      Console.WriteLine("2 - remover elemento");
      Console.WriteLine("3 - listar elementos");
      Console.WriteLine("4 - pesquisar elemento");
      Console.WriteLine("5 - ordenar elementos");
      Console.WriteLine("6 - sair");
      opcao = int.Parse(Console.ReadLine());
      if (opcao == 1){
        Console.WriteLine("Palavra a ser inserido:");
        al.Add(Console.ReadLine());
      }else if (opcao == 2){
        Console.WriteLine("Palavra a ser removido:");
        al.Remove(Console.ReadLine());
      }else if (opcao == 3){
        Console.WriteLine("Mostrar ArraList:");
        foreach (object o in al){
          Console.Write(o + " ");
        }
        Console.WriteLine();
      }else if (opcao == 4){
        Console.WriteLine("Palavra a ser pesquisado:");
        int palavra = Console.ReadLine();
        bool verificacao = al.Contains(palavra);
        Console.WriteLine($"Contém({palavra}): {verificacao}");
      }else if (opcao == 5){
        Console.WriteLine("Ordenando");
        al.Sort();
      }else if (opcao == 6){
        Console.WriteLine("Fim.");
      } else {
        Console.WriteLine("Opção Inválida.");
      }
    } while (opcao != 6);
  }
}

// Faça um programa contendo um ArrayList que armazena palavras e mostra as seguintes opções de escolha para o usuário: 1 - inserir elemento; 2 - remover elemento; 3 - listar elementos; 4 - pesquisar elemento; 5 - ordenar elementos; e 6 - sair. Quando o usuário escolher uma das opções, o programa realiza a operação escolhida no ArrayList.