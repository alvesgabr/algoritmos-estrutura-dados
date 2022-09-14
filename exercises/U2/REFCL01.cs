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
//Em nossa lista flexível, implemente um método que remove a segunda posição válida.
  public int RemoveSecond()
  {
    Node n = _head;
    int tdata = _head.next.next.data;
    _head.next = _head.next.next;
    n.next = null;
    return tdata;
  }

//Task - Em nossa lista flexível, implemente um método que retorna a soma os elementos contidos na mesma.
  public int Sum()
  {
    int temp = 0;
    for(Node n = _head; n != null; n = n.next)
    {
      temp += n.data;
    }
    return temp;
  }
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
    list.AddEnd(99);
    
    list.Print();
    Console.WriteLine();
    
    int logicallyRemoved = list.RemoveStartLog();
    int professorRemoved = list.RemoveStartProfessor();
    int secondRemoved = list.RemoveSecond();
    int listSum = list.Sum();
    
    Console.WriteLine($"\nHead Logically Removed: {logicallyRemoved}");
    Console.WriteLine($"Professor Removed: {professorRemoved}");
    Console.WriteLine($"Second Removed: {secondRemoved}");
    Console.WriteLine($"List Sum: {listSum}");
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