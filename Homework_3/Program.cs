using System;

class factorial
{
    static void Main()
    {
        string input;
        int i;
        int x;
        int sum = 1;

        //Ask to input an interger from keyboard
        Console.Write("Input an interger to compute factorial: ");

        //read input
        input = Console.ReadLine();

        //convert to interger
        i = int.Parse(input);

        //Check if input is not Negative
        if (i < 0)
        {
            Console.WriteLine("There can not have negative factorial!");
        }

        else
        {
            //start loop
            x = 1;
            while (x <= i)
            {
                sum = sum * x; // calculations
                x++;
            }
            Console.WriteLine("The factorial of {0} is {1}.", i, sum);
        }
        Console.ReadLine();
                    
    }
}