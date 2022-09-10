using System;
using System.Collections;
// task - explain what is happening here
class U01S03RS00{
  public static void Main(string[] args){
    //creating a new Queue named 'f' as its reference
    Queue f = new Queue();
    //enqueue means that each element is inserted just like a regular irl q
    f.Enqueue(1); f.Enqueue(2); f.Enqueue(3);
    //contains is a boolean if the value #1 is within the q 'f'
    //count is a method similar to .Length, it return an int of how many values are stored in the queue, same goes for arraylists or stacks
    //peek is a method used to 'peek', return* whats next, without removing it
    Console.Write($"Queue:{f.Contains(1)} / {f.Count} / {f.Peek()}\n");
    //deq is the oppo of enq, it removes the first value added, itc #1
    Console.WriteLine(f.Dequeue());
    //line 11 to 13
    Console.Write($"Queue:{f.Contains(1)} / {f.Count} / {f.Peek()}\n");


    //creating a new stack named 's' as its reference
    Stack s = new Stack();
    //push is just like enqueue, insert or add, its assigning a value to the stack, in this case, it would be #1, #2 and then #3, given its order
    s.Push(1); p.Push(2); p.Push(3);
    //line 11 to 13
    Console.Write($"Stack:{s.Contains(1)} / {s.Count} / {s.Peek()}\n");
    //unlike deq, pop will remove the last value added, itc #3
    Console.WriteLine(s.Pop());
    //line 11 to 13
    Console.Write($"Stack:{s.Contains(1)} / {s.Count} / {s.Peek()}\n");
  }
}