/*Indexers are usually known as smart array(virtual array ).
 Indexers allow instance of class to be indexed just like arrya.
 To define an indexers in C#, we use the 'this' keyword followed by index parameter in square bracket*/

using System;
class myClass
{
    private int[] data = new int[4]; //initialize array named data

    public int this[int i]
    {
        get { return data[i]; }
        set { data[i] = value; }
    }
}

namespace indexers
{
   class Program
    {

        static void Main(string[] args)
        {
            myClass myObj = new myClass(); //myClass object
            myObj[0] = 1;
            myObj[1] = 2;
            myObj[2] = 4;
            myObj[3] = 5;
            for(int i=0;i<4;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
