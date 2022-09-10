using System;

// References Class

class Student {
    public string name, email;
    public int id;

    public Student(){
        this.name = "";
        this.email = "";
        this.id = 0;
    }

    public Student(string name, int id, string email){
        this.name = name;
        this.email = email;
        this.id = id;
    }

    public void Print(){
        Console.WriteLine($"ID: {id}\nName: {name} - {email}\n");
    }
}
class refClass {
    public static void Main(string[] args) {
        Student s1  = null, s2 = null; // nt#1
        s1 = new Student("John Doe", 0001, "john@doe.com"); //builders
        s2 = new Student("Ann Smith", 0002, "ann@smith.com");
        s3 = new Student("David Lane", 0003, "david@lane.com");

        s2 = s1;
        s2.id = 0003;
        /*
        s1, s2, s3 are references, meaning, when s2.id is modified, so is s1
        s2 and s1 are poiting to the same object in memory after 's2 = s1;'
        */

        s1.Print();
        s2.Print();
        s3.Print();
    }
}

/*
Notes:
Note #1:

Variables used to reference an object are not to be mistakenly understood as objects themselves, they are merely pointers to an instance in the memory, hence why modifying s2.id will behave exactly as if s1.id had been modified.

*/