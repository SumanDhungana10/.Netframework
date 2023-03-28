using System;

namespace arryasinc_
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an arrya of an integer
            int[] num = { 20, 30, 10, 5, 50 };

            //Access the Elements of an Array
            Console.WriteLine("The 1st element in array is " + num[0]);

            //change an arrya element
            num[0] = 40;
            Console.WriteLine(num[0]);//output will be 40 insted of 20;

            //arrya length
            Console.WriteLine("the length of arrya is " + num.Length);

            //loop through an arrya
            Console.WriteLine("The elemnts of arrya are:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            //sort arrya
            Array.Sort(num);
            Console.WriteLine("The elemnts of arrya after sorting:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
}
