using System;

namespace The_Last_President
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * ADDING DATA INTO THE CLASS CHARACTER,TO USE LATER
             * 
             */

            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Sex (Male or Female): ");
            string sex = Console.ReadLine();

            Console.WriteLine("Enter the Age: ");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Place of Birth: ");
            string pob = Console.ReadLine();

            Console.WriteLine("Enter the occupation: ");
            string occupation = Console.ReadLine();

            Console.Clear();

            Character firstCharacter = new Character(name, sex, age, pob, occupation);
            Console.WriteLine("\n");
            Console.WriteLine(firstCharacter);
            Console.WriteLine("\n");
            Console.Read();
            Console.Clear();

            /*
             * 
             * MAIN STORY IMPLEMENTED HERE
             * 
             */

            if (sex == "male" || sex == "Male")
            {
                Console.WriteLine("The two presidents gathered to talk about their military power. At one time a president falls to the ground with a high fever and difficulty breathing and snuggle bouquet.Immediately evacuated another president and start Studies have body president. It soon became clear that he had been infected with the Covid-19.");
                Console.WriteLine("The president decides to leave his country.He wonders who will choose to be with him as a bodyguard and decides to choose you.");
                Console.WriteLine("The President: 'If someone has to be my bodyguard, I prefer it to be you, " + firstCharacter.Name + " !'");
            }
            else
            {
                Console.WriteLine("The two presidents gathered to talk about their military power. At one time a president falls to the ground with a high fever and difficulty breathing and snuggle bouquet.Immediately evacuated another president and start Studies have body president. It soon became clear that he had been infected with the Covid-19.");
                Console.WriteLine("The president decides to leave his country.He wonders who will choose to be with him as a bodyguard and decides to choose you.");
                Console.WriteLine("The President: 'If someone has to be my bodyguard, I prefer it to be you, " + firstCharacter.Name + "!'");
            }


            Console.Read();
            Console.Clear();


            /*
             * 
             * LOGIC FOR COUNTRIES IMPLEMENTED IN HERE FROM CLASS COUTRY 
             * 
             */


            //Adding different countries (info is from Wikipedia)
            //Country name = new Country(start population, current population, name, president status, status for logic);
            Country Bulgaria = new Country(6951482, 6951482, "Bulgaria", "Alive", true);
            Country Germany = new Country(83166711, 83166711, "Germany", "Alive", true);
            Country France = new Country(67147000, 67147000, "France", "Alive", true);
            Country Italy = new Country(60317116, 60317116, "Italy", "Alive", true);
            Country US = new Country(328239523, 328239523, "United States", "Alive", true);
            Country China = new Country(1400050000, 1400050000, "China", "Alive", true);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("List of All Countries You Will be Able to Play With:");

            Console.ResetColor();

            Console.WriteLine("\n");

            Console.WriteLine(Bulgaria);
            Console.WriteLine(Germany);
            Console.WriteLine(France);
            Console.WriteLine(Italy);
            Console.WriteLine(US);
            Console.WriteLine(China);


            Console.Read();
            Console.Clear();


            /*
             * 
             * GAME ROUNDS AND OTHER LOGIC IMPLEMENTED IN HERE
             * 
             */

            for (int i = 0; i < 1; i++)
            {

                //Show countries and give ability to choose where to go...

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Country List");

                Console.ResetColor();

                Console.WriteLine("\n");

                Console.WriteLine(Bulgaria);
                Console.WriteLine(Germany);
                Console.WriteLine(France);
                Console.WriteLine(Italy);
                Console.WriteLine(US);
                Console.WriteLine(China);

                choice choice;

                Console.ReadLine(choice);

                //Different code path depending on the choice

                switch (choice)
                {
                    case "Bulgaria":
                        Console.WriteLine("You choosed " + Bulgaria.NameOfCountry + " do you want to continue?");
                        string choiceToContinue;
                        Console.ReadLine(choiceToContinue);
                        if (choiceToContinue == "y" || choiceToContinue == "yes" || choiceToContinue == "Yes")
                        {
                            //code if continue
                        }// if else (choiceToContinue = "n" || choiceToContinue = "no || choiceToContinue = "No")
                        //{
                        //    //code if not continue
                        //} else
                        //{
                        //    break;
                        //}
                    case "Germany":
                        //logic for Bulgaria
                    case "France":
                        //logic for Bulgaria
                    case "Italy":
                        //logic for Bulgaria
                    case "US":
                        //logic for Bulgaria
                    case "China":
                    //logic for Bulgaria
                    default:
                        Console.WriteLine("Please write countries with capital later...");
                        break;
                }
            }


        }
    }
}
