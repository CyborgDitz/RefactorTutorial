using System;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        ArrayList myNumbers = new ArrayList();
        myNumbers.Add(1);
        myNumbers.Add(2);
        myNumbers.Add(3);
        myNumbers.Add(4);
        myNumbers.Add(5);

        for (int i = 0; i < myNumbers.Count; i++)
        {
            int number = (int)myNumbers[i];
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is even: " + number);
            }
            else if (number % 2 != 0)
            {
                Console.WriteLine("Number is odd: " + number);
            }
        }
        Console.ReadKey();
    }
}