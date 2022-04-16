using System;

namespace NumberAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello - what is your name?");
            string userName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName) == true)
                { userName = "User"; }

            string response;
            string cont = "y";

            while (cont == "y")
            {
                Console.WriteLine($"\n{userName} - Please Enter a Number between 1 and 100.");
                response = Console.ReadLine();
                bool isNumber = int.TryParse(response, out int myNumber);
               
                if (isNumber && myNumber >= 1 && myNumber <= 100)
                {
                    string numberType = (NumType(myNumber));
                    string numberRange = (NumRange(myNumber));
                    Console.WriteLine($"Your number is {numberType} and {numberRange}. \n");
                }
                else { Console.WriteLine("You entered an invalid number. \n"); }

                Console.WriteLine($"Do you want to continue {userName} (y/n)?");
                cont = Console.ReadLine();
            }
            Console.WriteLine("Thanks for playing. Good Bye!");
        }
        private static string NumType(int inNumber)
        {
            if (inNumber % 2 == 0) { return "Even"; }
            else { return "Odd"; }
        } 
        private static string NumRange(int inNumber)
        {
            string result;
            if (inNumber > 0 && inNumber < 60) { result = "less than 60"; }
            else if (inNumber > 1 && inNumber < 25) { result = "less than 25"; }
            else if (inNumber >= 26 && inNumber <= 60) { result = "between 26 and 60"; }
            else if (inNumber > 60 && inNumber <= 100 ) { result = "Greater than 60"; }
            else  { result = "not between 1 and 100"; }
            return result;
        }
    } 
}
