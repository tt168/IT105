//Assignment #6

// Review and Redo this code line by line at home.  

// Place comments on each line and describe what the code is doing

using System;

namespace ConsoleApplication1
{
    public struct Pet //establish structure 
    {
        public string Name;  //naming Name as string
        public string TypeOfPet;  //naming TypeOfPet as string
    }

    class Program
    {
        static void Main()
        {
            var numberOfPets = 0;  //declare and initiate numberOfPets
            var pets = new Pet[10];  //setup an array for 10 slots

            while (true)  //while loop started
            {
                Console.Write("A)dd D)elete L)ist pets:");  //waiting for an input
                var choice = Console.ReadLine(); //read input

                switch (choice)
                {
                    case "A":  //in case "A" or "a"
                    case "a":
                        {
                            Console.Write("Name :");  //waiting for input
                            var name = Console.ReadLine();  //read input

                            Console.Write("Type of pet :");  //waiting for input
                            var typeOfPet = Console.ReadLine();  //read input

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;  //writing Name into an array
                            pets[numberOfPets].TypeOfPet = typeOfPet;  //writing info into an array 

                            numberOfPets++;  // increase by +1
                            break;  //done return to top while()
                        }

                    case "D":  // check for option "D" or "d"
                    case "d":
                        {
                            if (numberOfPets == 0)  // control 
                            {
                                Console.WriteLine("No pets");  //display outcome
                                break; // done return to top while()
                            }

                            for (var index = 0; index < numberOfPets; index++) //control loop
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);  //display inputs
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets); //waiting for input

                            var petNumberToDelete = Console.ReadLine();  //read input
                            var indexToDelete = int.Parse(petNumberToDelete);  //change var to int

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++) // contol loop re-arranging the array
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--;  //reduce by 1

                            break; //done go back to top while()
                        }

                    case "L":  //case if  "L" or "l"
                    case "l":
                        {
                            if (numberOfPets == 0) //check statement
                            {
                                Console.WriteLine("No pets");  //display result
                            }

                            for (int index = 0; index < numberOfPets; index++)  //loop statement
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);  //display value
                            }

                            break;  //done go back to top while()
                        }
                    default: //switch operation
                        {
                            Console.WriteLine("Invalid option [{0}]", choice);     //display 
                            break;  // done go back to top while()
                        }
                }
            }
        }
    }
}