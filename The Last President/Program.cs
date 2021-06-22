using System;
using System.Reflection;
using static The_Last_President.Country;
using static The_Last_President.Character;
using System.Collections.Generic;

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

            Console.WriteLine("Enter the Place of Birth: ");
            string pob = Console.ReadLine();

            Console.Clear();

            string loc1 = pob;

            Character firstCharacter = new Character(name, sex, pob, loc1, 0);

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
                Console.WriteLine("One day there was a secret meeting of all the presidents about the contagion that had occurred. But no one suspected that one of these presidents was infected.");
                Console.WriteLine(" After falling to the ground, doctors and specialists entered the room with the infection, and so they identified that this president was infected. All the presidents returned to their countries and began to choose who would be worthy and most suitable for the job as a bodyguard.");
                Console.WriteLine("Many candidates passed, but in the end the presidents made a decision and elected you, " + firstCharacter.Name + "!'");
            }
            else
            {
                Console.WriteLine("On]y there was a secret meeting of all the presidents about the contagion that had occurred. But no one suspected that one of these presidents was infected.");
                Console.WriteLine(" After falling to the ground, doctors and specialists entered the room with the infection, and so they identified that this president was infected. All the presidents returned to their countries and began to choose who would be worthy and most suitable for the job as a bodyguard.");
                Console.WriteLine("Many candidates passed, but in the end the presidents made a decision and elected you, " + firstCharacter.Name + "!'");
            }
            Console.Read();

            Console.Read();
            Console.Clear();


            /*
             * 
             * LOGIC FOR COUNTRIES IMPLEMENTED IN HERE
             */


            //Adding different countries (info is from Wikipedia)

            List<Country> CountriesList = new List<Country>
            {
                new Country(6951482, 6951482, "Bulgaria", "Alive & Not Saved", true),
                new Country(83166711, 83166711, "Germany", "Alive & Not Saved", true),
                new Country(67147000, 67147000, "France", "Alive & Not Saved", true),
                new Country(60317116, 60317116, "Italy", "Alive & Not Saved", true),
                new Country(328239523, 328239523, "United States", "Alive & Not Saved", true)
            };

            //Making you place of birth country with saved president and adding +1 points.

            foreach (var obj in CountriesList)
            {
                if (firstCharacter.PlaceOfBirth == obj.NameOfCountry)
                {
                    obj.PresidentOfCountry = "Alive & Saved";
                    Console.WriteLine("Since you choose Bulgaria you automaticaly saved The President Of Bulgaria!");
                    firstCharacter.Points++;
                }
            }

          

            for (int i = 1; i < 100; i++)
            {

                //Show countries and give ability to choose where to go...

                /*
                 * 
                 * DEATHS AND PRESIDENTS
                 * 
                 */

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("            Country List            ");

                Console.ResetColor();

                Console.WriteLine("\n");


                foreach (var obj in CountriesList)
                {
                    DeathOrNot(obj);
                }

                Console.WriteLine("Which country would you like to go to?");

                string choice = Console.ReadLine();



                Console.WriteLine("\n");

                foreach (var obj in CountriesList)
                {
                    if (choice == obj.NameOfCountry)
                    {
                        playerMovement(obj, firstCharacter, obj.NameOfCountry);
                    }
                }
            }
        }
    }
}