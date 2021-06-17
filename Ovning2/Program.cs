using System;

namespace Ovning2
{
    class Program
    {

        static string age = " ";
        static string numberInTheGroup = "";
        static int intAge;
        static int totalCost = 0;
        static int intNumberInTheGroup;
        static int count = 0;
        static int intAgeOfGroupMember;
        static int cost = 0;
        static bool ThisIsAnIntAge = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Hi User, this is the main menu. \n" +
                "You will be navigated by numbers to test the functions. Choose a number or quit by pushing 0.");
            Menu();
        }





        private static void Menu()       
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1: Checking price if you are alone or in group\n2: Loop a text 10 times\n3: Divide long text to find the 3th word\n0: Exit the program");
                Console.WriteLine("----------------------------------------------");

                switch (Console.ReadLine())
                {
                    //0: to close the program
                    case "0":
                        Console.WriteLine("The program is closing. Bye!");
                        System.Environment.Exit(0);
                        break;


                    //1: to bye ticket
                    case "1":
                        Console.WriteLine("1: if you are alone, \n2: if you are in a group.");
                        string choice = Console.ReadLine();


                        //1.1: Checking in alone
                        if (choice == "1")
                        {
                            CheckingAlone();
                        }


                        //1.2: checking in a group
                        else if (choice == "2")
                        {
                            CheckingGroup();
                        }
                        else
                        {
                            Console.WriteLine("It is not the correct input. Please choose 1 or 2 nex time. Now we go back to the main menu. ");
                        }
                        break;


                    //2:Repeat text 10 times:  
                    case "2":
                        TextRepeat();
                        break;


                    //3: Finding the 3th word after dividing the text:
                    case "3":
                        DivideText();
                        break;


                    default:
                        Console.WriteLine("You should write a number: 0 to quit, 1 to checking, 2 to loop a text or 3 to divide a text.");
                        break;
                }
            }
            while (true);
        }

        private static void CheckingAlone()
        {
            bool isIntAge = false;
            do
            {
                Console.WriteLine("What is your age? ");
                age = Console.ReadLine();
                isIntAge = int.TryParse(age, out intAge);

                //if the input is a number:
                if (isIntAge == true)
                {
                    intAge = int.Parse(age);

                    if (intAge < 20)
                    {
                        Console.WriteLine("Youth Price = 80 kr");
                    }
                    else if (intAge > 64)
                    {
                        Console.WriteLine("Senior Price = 90 kr");
                    }
                    else
                    {
                        Console.WriteLine("Standardprice = 120 kr");
                    }

                }
                //if the input is not a number:
                else
                    Console.WriteLine("This is not the correct input. ");
            } while (isIntAge != true);
        }
        private static void CheckingGroup()
        {
            bool IsANumberForGroup = false;

            do
            {
                Console.WriteLine("How many are you in the group?");
                numberInTheGroup = Console.ReadLine();
                IsANumberForGroup = int.TryParse(numberInTheGroup, out intNumberInTheGroup);

                //if the input is a number for the group:
                if (IsANumberForGroup == true)
                {
                    GetGroupTotalCost();

                    Console.WriteLine("*****************************");
                    Console.WriteLine($"{count} people are in the group");
                    Console.WriteLine($"Total cost for the group = {totalCost} kr.\n");
                } 

                //it is not a "number input" for the group:
                else
                    Console.WriteLine("This is not the correct input. ");
            }
            while (IsANumberForGroup != true);
        }

        private static void GetGroupTotalCost()        
        {
            intNumberInTheGroup = int.Parse(numberInTheGroup);
            Console.WriteLine("Register the group members one by one."); 

            do
            {
                Console.WriteLine("What is your age? ");
                age = Console.ReadLine();               
                ThisIsAnIntAge = int.TryParse(age, out intAgeOfGroupMember);

                //If the input of age is a number (for group member):
                if (ThisIsAnIntAge == true)
                {
                    GetGroupMemberCost();
                }

                //If the input of age is not a number (for group member):
                else
                    Console.WriteLine("you have to write age as number.");
            }
            while (count < intNumberInTheGroup);
        }

        private static void GetGroupMemberCost() {
            intAgeOfGroupMember = int.Parse(age);

            // get price to the age
            if (intAgeOfGroupMember >= 5 && intAgeOfGroupMember < 20)
            {
                Console.WriteLine("Youth Price = 80 kr");
                cost = 80;
            }
            else if (intAgeOfGroupMember >= 20 && intAgeOfGroupMember <= 64)
            {
                Console.WriteLine("Standardprice = 120 kr");
                cost = 120;
            }
            else if (intAgeOfGroupMember > 64 && intAgeOfGroupMember <= 100)
            {
                Console.WriteLine("Senior Price = 90 kr");
                cost = 90;
            }
            else
            {
                Console.WriteLine("Standardprice = 0 kr. Gratis. ");
                cost = 0;
            }

            //get total cost for the whole group: 
            count++;
            totalCost += cost;
        }

        private static void TextRepeat()
        {
            Console.WriteLine("Write a text to repeat");
            string text = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
                Console.Write($"{i}.{text}!");
        }

        private static void DivideText()
        {
            Console.WriteLine("Write a long text to divide into parts (minimum 3 words):");
            string words = Console.ReadLine().Trim();
            if (!String.IsNullOrEmpty(words))
            {
                string[] lines = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"The 3.th word is \"{lines[2]}\"");
            }
            else Console.WriteLine("It is not an imput. Start again from the main menu.");
        }


        
    }

}

