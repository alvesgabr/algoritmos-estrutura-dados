using System;
using System.Collections;
class U01S02EC01 {
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
        Console.WriteLine("Número a ser inserido:");
        al.Add(int.Parse(Console.ReadLine()));
      }else if (opcao == 2){
        Console.WriteLine("Número a ser removido:");
        al.Remove(int.Parse(Console.ReadLine()));
      }else if (opcao == 3){
        Console.WriteLine("Mostrar ArraList:");
        foreach (object o in al){
          Console.Write(o + " ");
        }
        Console.WriteLine();
      }else if (opcao == 4){
        Console.WriteLine("Número a ser pesquisado:");
        int valor = int.Parse(Console.ReadLine());
        bool contains = al.Contains(valor);
        Console.WriteLine($"Contém({valor}): {contains}");
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

// A maioria dos sistemas computacionais que você terá a oportunidade de desenvolver ou trabalhar em sua vida profissional terá um cadastro de elementos. Em outras palavras, uma lista contendo as operações de inserir, ler, atualizar e apagar elementos. Na área de programação de computadores, esse minicadastro é chamado de CRUD, sigla em inglês para as palavras Create, Read, Update e Delete. Traduzindo, temos: criar, ler, atualizar e apagar, respectivamente. Neste exercício, faça um programa contendo um ArrayList que armazena números inteiros e mostra as seguintes opções de escolha para o usuário: 1 - inserir elemento; 2 - remover elemento; 3 - listar elementos; 4 - pesquisar elemento; 5 - ordenar elementos; e 6 - sair. Quando o usuário escolher uma das opções, o programa realiza a operação escolhida no ArrayList.