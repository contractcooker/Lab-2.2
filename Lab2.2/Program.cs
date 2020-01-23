using System;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int a;
            char prompt;
            double square;
            double cube;
            bool repeat = true;
            bool condition1 = true;
            bool condition2 = true;
            //Welcome!
            Console.WriteLine("This program squares and cubes numbers");

            //Console.WriteLine(Math.Pow(int.MaxValue, .33333));
            //Console.WriteLine(int.MaxValue);
            //Request input

            do
            {
                Console.Write("Please enter a positive integer: ");

                //get input
                string input = Console.ReadLine();

                //parse input
                bool parseTrue = int.TryParse(input, out a);



                //check that the input was in fact an integer and that it's > 0

                while ((!parseTrue || a <= 0 || a > Math.Pow(int.MaxValue, .33333)))
                {
                    
                    Console.WriteLine($"OUT OF BOUNDS OR NOT A POSITIVE INTEGER. " +
                        $"Please select a number" +
                        $"greater than 0 and less than" +
                        $" {Math.Pow(int.MaxValue, .33333)}");
                    Console.Write("Please try again: ");
                    input = Console.ReadLine();
                    parseTrue = int.TryParse(input, out a);                   
                  
                }  
                //generate the header
                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t=======\t\t=====");

                //step from 1 to input and display the number the cube and the square
                for (int i = 0; i < a; i++)
                {
                    int count = i + 1;
                    square = count * count;
                    cube = count * count * count;
                    Console.WriteLine($"{count}\t\t{square}\t\t{cube}");
                }
                Console.WriteLine();
                //check to see if the user would like to choose another number
                Console.Write("Would you like to play again? (y/n): ");
                input = Console.ReadLine();

                //validate input
                parseTrue = char.TryParse(input, out prompt);
                prompt = char.ToUpper(prompt);
                while (parseTrue && prompt != 'Y' && prompt != 'N')
                {
                    Console.WriteLine("Please answer using 'y' or 'n'.");
                    Console.Write("Please try again: ");
                    input = Console.ReadLine();
                    parseTrue = char.TryParse(input, out prompt);
                    prompt = char.ToUpper(prompt);
                    Console.WriteLine(prompt);

                }
                if (prompt == 'Y')
                {
                    continue;
                }
                else if (prompt == 'N')
                {
                    repeat = false;
                }
                else
                {
                    repeat = false;
                }

            } while (repeat) ;
        }
    }
}
