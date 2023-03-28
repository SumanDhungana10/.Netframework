/*inheritance allows us to create a new class from an existing class. 
The class from which a new class is created is known as the base class (parent or superclass).
And, the new class is called derived class (child or subclass)
The derived class inherits the fields and methods of the base class. */

using System;
     
       public class Employee  
        {  
           public float salary = 0;  
       }  
       public class Programmer: Employee  
       {  
           public float bonus = 0;  
       }

namespace inheritance
{
    class Program
    {


        public static void Main(string[] args)
        {
            Programmer p1 = new Programmer();
            p1.salary = 4000;
            p1.bonus = 1000;

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);

        }

    }
}
