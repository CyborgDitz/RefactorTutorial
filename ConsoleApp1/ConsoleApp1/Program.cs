using System;
using System.Collections;

//todo list scope, write line simp
class Program
{
    static void Main(string[] args)
    {
        //I see the problem here lol. The numbers are not scoped.
        List<int> numbers = new List<int>{1, 2, 3, 4, 5};
        
        foreach (int number in numbers)
        {
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