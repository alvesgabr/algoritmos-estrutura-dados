using System;
using System.Collections.Generic;

// ¯\_(ツ)_/¯

class U01S04LL01 {
  public static void Main(string[] args){
    // words im using to insert at the ll
    string[] words = {"John", "Dave", "Ann", "Sara", "James", "Carl", "Matthew", "Bill", "Mark", "Noah", "Grace", "Charlie"};

    // creating new ll
    LinkedList<string> ll = new LinkedList<string>(words);

    // adding first string to the empty ll
    // AddFirst
    ll.AddFirst("Liam");

    // loop with all words' words
    // AddLast
    foreach (string word in words){
      ll.AddLast(word);
      Console.WriteLine($"{word} added!");
    }

    // AddAfter, AddBefore John
    LinkedListNode<string> nodeJ = ll.Find("John");
    ll.AddAfter(nodeJ, "HI JOHN");
    ll.AddBefore(nodeJ, "WHOM A I?");

    // Remove
    ll.Remove("John");

    // Death Game
    Console.WriteLine($"\nDeath game, guess a number between 0 and 2 to remove the first name!");
    int option = int.Parse(Console.ReadLine());
    if (option == 1){
      Console.WriteLine($"Gotcha bitch! Removing the last 5 names...!");
      
      for(int i = 0; i < 5; i++){
        //RemoveLast
        ll.RemoveLast();
      }
    } else if (option == 2){
      Console.WriteLine($"Clever fam, huh, I see how it is.\nRemoving first name...");

      // RemoveFirst
      ll.RemoveFirst();
      Console.WriteLine($"\nI'll wipe it anyway, KEKW");
      ll.Clear();
    } else {
      Console.WriteLine($"HA! WIPING ALL DATA, U TWAT!");

      // CLear()
      ll.Clear();
    }

    // I WAS BORED
    Console.WriteLine($"\nWhat's your name again?");
    string userName = Console.ReadLine();
    ll.AddFirst($"{userName}");

    for(int i = 0; i < words.Length; i++){
      ll.AddLast(words[i]);
    }
    Console.WriteLine("List restored!");


    Console.WriteLine("\nTry searching your name:");
    string answer =  Console.ReadLine();
    if(answer != userName) {
      do {
        Console.WriteLine("You think you're clever huh...Try again!");
        answer = Console.ReadLine();
      } while (answer != userName);
    }
    Console.WriteLine($"\nHope you enjoyed your time in my loop whole, STUPID {userName.ToUpper()}.");

    Console.WriteLine($"\nHere, let me check your name on my VIP list...\n");
    if (ll.Contains(userName) == true){
      LinkedListNode<string> nameNode = ll.Find($"{userName}");
      Console.WriteLine($"It works, I found you at this thing:\nNode: {nameNode}\n\n\n\n\ndon't ask me");
    } else {
      Console.WriteLine("Well, this wasn't supposed to happen");
    }

    // random Johns ¯\_(ツ)_/¯
    for(int i = 0; i < 5; i++){
      int random = Math.Abs((new Random()).Next()) % words.Length;
      LinkedListNode<string> rdmJohn = ll.Find(words[random]);
      ll.AddAfter(rdmJohn, "John");
    }
  }
}