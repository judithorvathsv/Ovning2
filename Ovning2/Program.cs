using System;

namespace Ovning2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hi User, this is the main menu. \n" +
                "You will be navigated by numbers to test the functions. Choose a number or quit by pushing 0.");
            Menu();
        }






        private static void Menu()
        {
            string age = " ";
            string numberInTheGroup = "";
            int intAge;
            int totalCost = 0;
            int fulltotal = 0;

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
                            bool isIntAge = false;
                            do
                            {
                                Console.WriteLine("What is your age? ");
                                age = Console.ReadLine();
                                isIntAge = int.TryParse(age, out intAge);

                                //if the input is a number:
                                if (isIntAge==true)
                                {
                                        intAge = int.Parse(age);

                                        if (intAge < 20)
                                        {
                                            Console.WriteLine("Youth Price = 80 kr"); 
                                        totalCost = 80;
                                        }
                                        else if (intAge > 64)
                                        {
                                            Console.WriteLine("Senior Price = 90 kr"); 
                                        totalCost = 90;
                                    }
                                        else
                                        {
                                            Console.WriteLine("Standardprice = 120 kr"); 
                                        totalCost = 120;
                                    }
                                       
                                      }
                                //if the input is not a number:
                                else
                                    Console.WriteLine("This is not the correct input. ");
                            } while (isIntAge != true);
                        }






                        //1.2: checking in a group
                        else if (choice == "2")
                        {
                            bool IsANumberForGroup = false;

                            do
                            {
                                Console.WriteLine("How many are you in the group?");
                                numberInTheGroup = Console.ReadLine();
                                int intNumberInTheGroup;
                                IsANumberForGroup = int.TryParse(numberInTheGroup, out intNumberInTheGroup);

                                //if the input is a number for the group:
                                if (IsANumberForGroup == true)
                                {
                                    intNumberInTheGroup = int.Parse(numberInTheGroup);
                                    Console.WriteLine("Register the group members one by one.");

                                    int count = 0;
                                    int cost = 0;
                                 //   int totalCost = 0;
                                    bool ThisIsAnIntAge = false;


                                    do
                                    {
                                        //get a price to age
                                        Console.WriteLine("What is your age? ");
                                        age = Console.ReadLine();
                                        int intAgeOfGroupMember;
                                        ThisIsAnIntAge = int.TryParse(age, out intAgeOfGroupMember);

                                                 //If the input of the group () how many people is in the group) is a number AND the input for the age of the member is also a number:
                                                 if (ThisIsAnIntAge == true) {
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
                                                                //if the age for a member in the group is not a number:
                                                                else                                        
                                                                    Console.WriteLine("you have to write age as number.");                                      

                                    }
                                    while (count < intNumberInTheGroup);

                                    Console.WriteLine("*****************************");
                                    Console.WriteLine($"{count} people are in the group");
                                    Console.WriteLine($"Total cost: {totalCost} kr.\n");
                                } //end of the: "if the input is a number for the group:" part


                                //it is not a "number input" for the group:
                                else
                                    Console.WriteLine("This is not the correct input. ");

                            }
                            while (IsANumberForGroup != true);
                        } //end of the checking in the group

                       else { Console.WriteLine("It is not the correct input. Please choose 1 or 2 nex time. Now we go back to the main menu. "); }

                        break;







                    //2:Repeat text 10 times:  
                    case "2":                        
                        Console.WriteLine("Write a text to repeat");
                        string text = Console.ReadLine();
                        for (int i = 1; i <= 10; i++)
                            Console.Write($"{i}.{text}!");                     
                        break;



                    //3: Finding the 3th word after dividing the text:
                    case "3":                        
                        Console.WriteLine("Write a long text to divide into parts (minimum 3 words):");
                        string words = Console.ReadLine().Trim();
                        if ( !String.IsNullOrEmpty(words))
                        {
                            string[] lines = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            Console.WriteLine($"The 3.th word is \"{lines[2]}\"");
                        }
                        else Console.WriteLine("It is not an imput. Start again from the main menu.");
                        break;



                    default:
                        Console.WriteLine("You should write a number: 0 to quit, 1 to checking, 2 to loop a text or 3 to divide a text.");
                        break;
                }
                
                //if you register a person alone and a group also and they want to pay together:
                fulltotal += totalCost;
                Console.WriteLine($"Full total: {totalCost} kr");
            }
            while (true);

        }
    }

}

