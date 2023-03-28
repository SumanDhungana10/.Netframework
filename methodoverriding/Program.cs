/*If the same method is present in both the base class and the derived class,
 the method in the derived class overrides the method in the base class. This is called method overriding.

To perform method overriding in C#, 
we need to use virtual keyword with base class method and override keyword with derived class method.
 
 */


using System;

namespace methodoverriding
{

    // base class
    class Animal
    {
        public virtual void eat()
        {

            Console.WriteLine("I eat food");
        }

    }

    // derived class of Animal 
    class Dog : Animal
    {

        // overriding method from Animal
        public override void eat()
        {

            Console.WriteLine("I eat Dog food");
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            // object of derived class
            Dog labrador = new Dog();

            // accesses overridden method
            labrador.eat();
        }
    }
}
