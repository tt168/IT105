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
        Console.Write("Enter an interger: ");

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
                Console.WriteLine("     {0}!   =    {1}", x, sum); //Print each iteration 
                x++;
            }

        }//end else
        Console.ReadLine();
    }
}