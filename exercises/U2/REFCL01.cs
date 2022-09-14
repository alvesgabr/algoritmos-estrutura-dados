using System;
// trying to get used to newLine{}
class Node
{
  public int data;
  public Node next;

  public Node()
  {
    this.data = 0;
    this.next = null;
  }

  public Node(int n)
  {
    this.data = n;
    this.next = null;
  }

}
class List
{
  private Node _head, _tail;
  
  public List()
  {
    _head = _tail = new Node();
  }

// insert at the next 'node', & for addEnd, change pointer pos
  public void AddStart(int n)
  {
    Node temp = new Node(n);     // new node of data n
    temp.next = _head.next;      // next pointer of node temp = next pointer of initial node
    _head.next = temp;           // next pointer ini node = node temp (not pointer!)
    if(_head == _tail)           // if initial and last node pointers are the same:
      _tail = temp;              // last node pointer moves to temp node
    temp = null;                 // nullify temp for clean up
  }

  public void AddEnd(int n)
  {
    _tail.next = new Node(n);
    _tail = _tail.next;
  }

  public int RemoveStartLog()
  {
    if(_head == _tail)
    {
      Console.WriteLine("Invalid Command - ERR001: First and Last Node are the same!");
      Environment.Exit(0);
    }

    Node temp = _head;
    _head = _head.next;       // moving initial pointer
    int tdata = _head.data;   // assign new initial pointer data to temp var
    temp = temp.next = null;  // discard temp
    return tdata;             // return value
  }
// Task 1 - Modify RemoveStartLog to remove the first node phisically, I have 2 solutions below, A and B

// A solution - assing data 0 to the new first node
  public int RemoveStartPhysA()
  {
    if(_head == _tail)
    {
      Console.WriteLine("Invalid Command - ERR001: First and Last Node are the same!");
      Environment.Exit(0);
    }

    Node temp = _head;
    _head = _head.next;       // moving initial pointer
    int tdata = _head.data;   // assign new initial pointer data to temp var
    _head.data = 0;           // declaring 0 to first node data
    return tdata;             // return value
  }

// B solution - declares a new node and copies the past first node reference and discard everything behind.
  public int RemoveStartPhysB()
  {
    if(_head == _tail)
    {
      Console.WriteLine("Invalid Command - ERR001: First and Last Node are the same!");
      Environment.Exit(0);
    }
    Node temp = new Node();              // declare new node
    temp.next = _head.next.next;         // assign pointers for temp as third node
    int tdata = _head.next.data;         // store returning data
    _head = temp;                        // moving pointers
    return tdata;                        // return value
  }

// Conclusion: Solution B is unefficient

// Professor Solution to Task 1
  public int RemoveStartProfessor()
  {
    if(_head == _tail)
    {
      Console.WriteLine("Invalid Command - ERR001: First and Last Node are the same!");
      Environment.Exit(0);
    }
    
    Node temp = _head.next;
    _head.next = _head.next.next;
    int tdata = temp.data;
    temp = temp.next = null;
    return tdata;
  }
  public int RemoveEnd()
  {
    // node check and error reporting
    if(_head == _tail)
    {
      Console.WriteLine("Invalid Command - ERR001: First and Last Node are the same!");
      Environment.Exit(0);
    }
    
    Node temp;                // new temporary node
    // running thru the list node:node and assign temp as Last Node
    for(temp = _head; temp.next != _tail; temp = temp.next);
    int tdata = _tail.data;   // assign last node data to temp data
    _tail = temp;             // last node points to previous node (temp node pointer)
    temp = _tail.next = null; // tempnode and last next node pointers nullyfied
    return tdata;             // return data stored at temp data, now nullyfied
  }

  public void AddPosition(int n, int pos)
  {
    int size = ListSize();
    if(pos < 0 || pos > size)
    {
      Console.WriteLine("Invalid Command - ERR002: Invalid Position!");
      Environment.Exit(0);
    } 
    else if (pos == 0)
    {
      AddStart(n);
    }
    else if (pos == size)
    {
      AddEnd(n);
    } 
    else
    {
    Node temp = _head;        // mark temp pointer to first node
    // run thru array and moving temp pointer along with counter
    for(int i = 0; i < pos; i++, temp = temp.next); 
    Node stemp = new Node(n); // declare new node with the desired value
    stemp.next = temp.next;   // connect new node to pos + 1
    temp.next = stemp;        // connect pos node to new node
    stemp = temp = null;      // nullyfing both temps
    }
  }
  
  /*public int RemovePosition(int pos)
  {
    int tdata, size = ListSize();
    if(_head == _tail || pos < 0 || pos >= size)
    {
      Console.WriteLine("Invalid Command - ERR002: Invalid Position!");
      Environment.Exit(0);
    }
    else if (pos == 0)
    {
      tdata = RemoveStartLog();
    }
    else if (pos == size - 1)
    {
      tdata = RemoveEnd();
    }
    else
    {
      Node n = _head; // declare moving node for loop
      for(int i = 0; i < pos; i++, n = n.next); // moving n node
      Node temp = n.next; // temp node marks pos
      tdata = temp.data; // return data is marked pos node
      n.next = temp.next; // n node points to next node pointer
      temp.next = null; // cleaning up, nullyfing
      n = temp = null;
    }
    return tdata;
  }*/

  public void Print()
  {
    Console.Write("{ ");
    // usage of reference instead of a counter
    for(Node n = _head.next; n != null; n = n.next)
    {
      Console.Write($"{n.data} ");
    }
    Console.Write("}");
  }

  public int ListSize()
  {
    int size = 0;
    for(Node n = _head; n != _tail; n = n.next, size++);
    return size;
  }

// Task 1 - Em nossa lista flexível, implemente um método que remove a segunda posição válida.
  public int RemoveSecond()
  {
    int tdata = _head.next.next.data;
    _head.next.next = _head.next.next.next; // this is ugly, but it works
    return tdata;
  }

// Task 2 - Em nossa lista flexível, implemente um método que retorna a soma os elementos contidos na mesma.
  public int Sum()
  {
    int temp = 0;
    for(Node n = _head.next; n != null; n = n.next)
    {
      temp += n.data;
    }
    return temp;
  }

// Task 3 - Em nossa lista flexível, implemente um método que retorna o maior elemento contido na mesma.
  public int HighestInt()
  {
    int highest = 0;
    for(Node n = _head; n != null; n = n.next)
    {
      if(n.data > highest)
        highest = n.data;
    }
    return highest;
  }

// Task 4 - Em nossa lista flexível, implemente um método que retorna o terceiro elemento supondo que o mesmo existe.
  public int ThirdValue()
  {
    int tdata = 0;
    Node temp = _head.next.next.next;
    if(temp != null)
    {
      tdata = temp.data;
    }
    return tdata;
  }

// Task 5 - Em nossa lista flexível, implemente um método que inverte a ordem dos seus elementos.
  public void Reverse()
  {
    Node prev = null, curr = _head, next = null;
    while(curr != null)
    {
      next = curr.next;
      curr.next = prev;
      prev = curr;
      curr = next;
    }
    _head = prev;
  }

// Task 6 - Em nossa lista flexível, implemente um método que retorna o número de elementos pares and múltiplos de cinco contidos na mesma.
  public int MultiplesOfTwonFive()
  {
    int tmp = 0;
    for(Node n = _head.next; n != null; n = n.next)
    {
      if((n.data % 2 == 0) && (n.data % 5 == 0))
      {
        tmp++;
      }
    }
    return tmp;
  }

// Task 7 - Modifique nossa lista flexível, de tal forma que ela não tenha a referência último.
  public void CutTail()
  {
    if(_head == _tail)
      Console.WriteLine("Error");
    Node n = _head;
    while(n.next.next != null)
      n = n.next;
    _tail = n;
    _tail.next = null;
  }

// Task 8 - Modifique nossa lista flexível, criando uma fila flexível.
// ngl, this is unecessary of a task, simply force only the following methods
// AddToEnd and RemoveAtStart and it will behave just like a queue;

// Task 9 - Modifique nossa lista flexível, criando uma pilha flexível.
// just like previous task, simply remove all insertion and removal methods
// other than AddToEnd and RemoveAtEnd and it will behave just like a normal stack;

// Task 10 - Modifique nossa lista flexível, criando uma lista ordenada.
// im confused at this one, i guess the professor wants a sort method, ill give my fair shot;
  public void Sort()
  {
    Node tmp = _head.next, next = null, prev = null;
    for(Node n = _head.next; n != null; n = n.next)
    {
      if(tmp.data > tmp.next.data)
      {
        next = tmp;
        prev = tmp.next;
        tmp.next = prev;
        tmp = next;
      }
    }
  }
// it should work but i guess it isnt, idk why tho

// Task 11 - Modifique nossa lista flexível, criando uma lista duplamente encadeada.
// idk what this means, and i haven't seen any class referring to it yet
// ill probably do it eventually at an external class, but im either dumb or never met this b4
}

class REFCL01
{
  static void Main(string[] args)
  {
    List list = new List();
    for(int i = 1; i <= 10; i++)
    {
      list.AddEnd(i);
    }
    list.AddStart(11);
    list.AddStart(12);
    list.AddPosition(20, 2);
    
    list.Print();
    Console.WriteLine();
    
    int listSum = list.Sum();
    int thirdInt = list.ThirdValue();
    int highestInt = list.HighestInt();
    int secondRemoved = list.RemoveSecond();
    int logicallyRemoved = list.RemoveStartLog();
    int professorRemoved = list.RemoveStartProfessor();
    int multiplesOf = list.MultiplesOfTwonFive();

    Console.WriteLine("\nCut Tail:");
    list.CutTail();
    list.Print();
    list.Sort();
    Console.WriteLine();
    list.Print();
    list.Reverse(); // not working properly, ill return to it later
    // output is { 9 8 7 6 5 4 3 2 1 12 }, og list { 1 2 3 4 5 6 7 8 9 10 }
    
    Console.WriteLine($"\n\nList Sum: {listSum}");
    Console.WriteLine($"Third Value: {thirdInt}");
    Console.WriteLine($"Highest Value: {highestInt}");
    Console.WriteLine($"Second Removed: {secondRemoved}");
    Console.WriteLine($"Head Logically Removed: {logicallyRemoved}");
    Console.WriteLine($"Head Professor Removed: {professorRemoved}");
    Console.WriteLine($"Multiples of 2 and 5: {multiplesOf}");

    Console.WriteLine("\nReversed && Broken LinkedList: ");
    list.Print();
  }
}
/*
Methods with Bugs:
    
RemoveStartPhysA & RemoveStartPhysB
    
int physicallyRemovedA = list.RemoveStartPhysA();
int physicallyRemovedB = list.RemoveStartPhysB();

Console.WriteLine($"Head Phsyically Removed A: {physicallyRemovedA}");
Console.WriteLine($"Head Phsyically Removed B: {physicallyRemovedB}");
*/

// ---------------------------------- //

/*
Not functional methods:

RemovePosition(n) & RemoveEnd()

int posRemove = list.RemovePosition(2);
Console.WriteLine($"Position {pos} Removed:\n{posRemove}");

int tailRemove = list.RemoveEnd();
Console.WriteLine($"End of List Removed: {tailRemove}");    
*/

// So far so good, had 4 methods with problems, 2 of which work but barely;
// My reverse method doesnt work properly, it cuts off the tail, idk why yet;
// I'm semi proud and hopefully I get more practice soon;

// GG