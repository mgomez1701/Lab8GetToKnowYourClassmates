using System;

namespace GTKYCM_Lab
{
    class Program
    { //global array? 
        static void Main(string[] args)
        {
            bool letsGo = true; //seeting this to use later
            string[] students = { "1). Mordacai Schroader", "2). Freddy Hendrix", "3). Titus McNair", "4). Khabib Nurmagomedov", "5). Joe Rogan" };
            int index = ValidateRange("Which student would you like to learn more about ? (enter a number 1 - 5)", 0, students.Length); // mayneed  set tp 1 //Array.Sort(students);

            Console.WriteLine(StudentSelect(index));
            GetContinue();
            
             WeContinue(letsGo);          
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int ParseInput(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Not in the correct format");
                return ParseInput(message);
            }
            catch 
            {
                return ParseInput(message);
            }
        }
        public static int ValidateRange(string message, int min, int max) // used this instead of a try catch
        {
            int number = ParseInput(message);
            if (number > min && number <= max)
            {
                return number;
            }


            else
            {
                return ValidateRange(message, min, max);
            }
        }

        public static string StudentSelect(int index)
        {

            if (index == 1)
            {

                Console.WriteLine($"Student {index} is Mordacai Schroader");
                string userInput= GetUserInput($"What would you like to know about Mordacai? Enter hometown or favorite food");
                  
                    switch (userInput) 
                    {
                        case "hometown":
                        case "Hometown":
                        case  "HomeTown":
                            return "Mordacai was born in a forest, under a tree, with animals all around him. Holding a basketball. No one knows exactly where. Myth is somewhere in the middle east...";
                        case "favorite food":
                        case "Favorite food":
                        case "Favorite Food":
                            return "Mordacai's favorite food is rebounds with a side of buckets";
                        default:
                            return "That is an incorrect input. Please try again. Choose hometown or favorite foods"; // ask about how to get this to return back to question if invalid key// 
                    }
               
            }

            else if (index == 2)
            {
                Console.WriteLine($"Student {index} is Freddy Hendrix ");
                string userInput = GetUserInput($"What would you like to know about Freddy? Enter hometown or favorite food");

                switch (userInput.ToLower()) // ask why  the try catch didnt work here. does a string mean there is no formatexception?// 
                {
                    case "hometown":
              
                        return "Freddy was born in New London, Boston. He has ties to the south and his mother is from the UK.";
                    case "favorite food":
                    case "Favorite food":
                    case "Favorite Food":
                        return "Freddy's favorite food are fish and waffles";
                    default:
                        return "That is an incorrect input. Please try again. Choose hometown or favorite foods";

                }
            }
            else if (index == 3)
            {
                Console.WriteLine($"Student {index} is Titus McNair ");
                string userInput = GetUserInput($"What would you like to know about Titus McNair? Enter hometown or favorite food");

                switch (userInput) 
                {
                    case "hometown":
                    case "Hometown":
                    case "HomeTown":
                        return "Titus was born during the Music City Miracle in Nashville, Tennessee";
                    case "favorite food":
                    case "Favorite food":
                    case "Favorite Food":
                        return "Titus's favorite food is ribs aged more than 3 days";
                    default:
                        return "That is an incorrect input. Please try again. Choose hometown or favorite foods";

                }
            }
            else if (index == 4)
            {
                Console.WriteLine($"Student {index} is Khabib Nurmagomedov");
                string userInput = GetUserInput($"What would you like to know about Khabib? Enter hometown or favorite food");

                switch (userInput) 
                {
                    case "hometown":
                    case "Hometown":
                    case "HomeTown":
                        return "Khabib is from Dagestan, Russia. Where the population is around 3million and they have 22 olympic wrestlers.";
                    case "favorite food":
                    case "Favorite food":
                    case "Favorite Food":
                        return "Khabib's favorite food is whatever the bear is eating...";
                    default:
                        return "That is an incorrect input. Please try again. Choose hometown or favorite foods";

                }
            }
            else if (index == 5)
            {
                Console.WriteLine($"Student {index} is Joe Rogan");
                string userInput = GetUserInput($"What would you like to know about Joe? Enter hometown or favorite food");

                switch (userInput) 
                {
                    case "hometown":
                    case "Hometown":
                    case "HomeTown":
                        return "Joe Rogan was born in Newark, New Jersey";
                    case "favorite food":
                    case "Favorite food":
                    case "Favorite Food":
                        return "Joe's favorite food is elk that he hunts himself for his family and friends.";
                    default:
                        return "That is an incorrect input. Please try again. Choose hometown or favorite foods";
                }
            }

            return "";
        }
        public static bool GetContinue()
        {
            bool letsGo = true;
            
            // input from iser on whether they want to conintue (y/n)
            Console.WriteLine($"Do you want to find out somemore cool things about the class? y/n");
            // processing - if y, retun true, if n, return false,
            // if neither, call GetContinue() 
            string userContinue = Console.ReadLine();

            switch (userContinue.ToLower())
            {
                case "y":
                    return letsGo;
                case "n":
                    return false;
                default:
                    return GetContinue();
            }

            
        }

        public static string WeContinue(bool keepGoing)
        {
            string[] students = { "1). Mordacai Schroader", "2). Freddy Hendrix", "3). Titus McNair", "4). Khabib Nurmagomedov", "5). Joe Rogan" };
            int index = ValidateRange("Which student would you like to learn more about ? (enter a number 1 - 5)", 0, students.Length);

            Console.WriteLine(StudentSelect(index));

            return "";

        }
    }
} // things to possibly add 
// two more pieces of info for each person.
// allow user to search by number as well. maybe list the people with the number
        

  
