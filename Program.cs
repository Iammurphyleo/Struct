// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//struct

//The struct (structure) is like a class in C# that is used to store data. However, unlike classes, a struct is a value type.Suppose we want to store the name and age of a person. We can create two variables: name and age and store value.However, suppose we want to store the same information of multiple people.In this case, creating variables for an individual person might be a tedious task. To overcome this we can create a struct that stores name and age. Now, this struct can be used for every person.

//Structure is a value type and a collection of variables of different data types under a single unit. It is almost similar to a class because both are user-defined data types and both hold a bunch of different data types. C# provide the ability to use pre-defined data types. However, sometimes the user might be in need to define its own data types which are also known as User-Defined Data Types. Although it comes under the value type, the user can modify it according to requirements and that’s why it is also termed as the user-defined data type.

//Defining Structure: In C#, structure is defined using struct keyword. Using struct keyword one can define the structure consisting of different data types in it. A structure can also contain constructors, constants, fields, methods, properties, indexers and events etc.

// Class or Structure?
//How to decide when to use a class and when a structure? We will give you some general guidelines.Use structures to hold simple data structures consisting of few fields that come together. Examples are coordinates, sizes, locations, colors, etc. Structures are not supposed to have functionality inside (no methods except simple ones like ToString() and comparators). Use structures for small data structures consisting of set of fields that should be passed by value.
//Use classes for more complex scenarios where you combine data and programming logic into a class. If you have logic, use a class. If you have more than few simple fields, use a class. If you need to pass variables by reference, use a class. If you need to assign a null value, prefer using a class. If you prefer working with a reference type, use a class.

//Define struct in C#
//In C#, we use the struct keyword to define a struct. For example,

/*struct Employee
{
    public int id;
}*/
//Here, id is a field inside the struct. A struct can include methods, indexers, etc as well.

//Declare struct variable
//Before we use a struct, we first need to create a struct variable. We use a struct name with a variable to declare a struct variable. For example,



// declare emp of struct Employee
//Employee emp;

//struct Employee
//{
   // public int id;
//}
//In the above example, we have created a struct named Employee.Here, we have declared a variable emp of the struct Employee.

// Employee emp;
// emp.id = 5;
// emp.name = "kunle";
// emp.GetInfo(emp.id, emp.name);

//calling the default constructor
// Employee emp = new Employee();
// emp.id = 5;
// emp.name = "kunle";
// emp.GetInfo(emp.id, emp.name);

//calling the constructor
Employee emp = new Employee(5, " titi");
Console.WriteLine($"your name is {emp.name} and your id is {emp.id}");
//calling the method through the instance
emp.GetInfo(5, "kunle");

//showing the difference btw struct and constructor
//Conductor con1 = new Conductor(5, "jide"); //calling the constructor for class
Conductor con1 = new Conductor();
      con1.name = "John";
      con1.id = 5;

      // assign con1 to con2
     Conductor con2 = con1;
      con2.name = "Ed";
      con2.id = 8;
      con1.GetInfo(con1.id, con1.name);
      //struct will print different values and class print same value
      //Console.WriteLine("Employee1 name: " + con1.name);

struct Employee
{
    public int id;
     public string name;
     public void GetInfo(int id, string name)
     {
        Console.WriteLine($"your name is {name} and your id is {id}");
     }

    //using constructor
    public Employee(int Id, string Name)
     {
        id = Id;
        name = Name;
     }

     //Note: We must assign the value for every field of struct inside the parameterized constructor. For example,

    // error code
    //  public Employee(int employeeID, employeeName) 
    //   {
    //     id = employeeID;
    //   }
}

// Defining struct with property, all operations as done in the above employee is amplicable here too
  struct Employer 
  {
    public int id;
    
    // creates property
    public int Id {

      // returns id field
      get {
        return id;
      }

      // sets id field
      set {
        id = value;
      }
    }
  }

  //Difference between class and struct in C#
//In C# classes and structs look similar. However, there are some differences between them.A class is a reference type whereas a struct is a value type. For example,
// if a struct has a constructor, the default parameter can still be called
// struct can be inherited and cant be be inherited from
struct Conductor
//class Conductor
{
    public int id;
     public string name;
     public void GetInfo(int id, string name)
     {
        Console.WriteLine($"your name is {name} and your id is {id}");
     }

    //using constructor
    public Conductor(int Id, string Name)
     {
        id = Id;
        name = Name;
     }

}

