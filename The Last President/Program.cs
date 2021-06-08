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

            //if (firstCharacter.PlaceOfBirth == "Bulgaria")
            //{
            //    CountriesList.Bulgaria.PresidentOfCountry = "Alive & Saved";
            //    Console.WriteLine("Since you choose Bulgaria you automaticaly saved The President Of Bulgaria!");
            //    firstCharacter.Points++;
            //}
            //else if (firstCharacter.PlaceOfBirth == "Germany")
            //{
            //    Germany.PresidentOfCountry = "Alive & Saved";
            //    Console.WriteLine("Since you choose Germany you automaticaly saved The President Of Germany!");
            //    firstCharacter.Points++;
            //}
            //else if (firstCharacter.PlaceOfBirth == "France")
            //{
            //    France.PresidentOfCountry = "Alive & Saved";
            //    Console.WriteLine("Since you choose France you automaticaly saved The President Of France!");
            //    firstCharacter.Points++;
            //}
            //else if (firstCharacter.PlaceOfBirth == "Italy")
            //{
            //    Italy.PresidentOfCountry = "Alive & Saved";
            //    Console.WriteLine("Since you choose Italy you automaticaly saved The President Of Italy");
            //    firstCharacter.Points++;
            //}
            //else if (firstCharacter.PlaceOfBirth == "US")
            //{
            //    US.PresidentOfCountry = "Alive & Saved";
            //    Console.WriteLine("Since you choose United States you automaticaly saved The President Of United States!");
            //    firstCharacter.Points++;
            //}
            //else
            //{
            //    Console.WriteLine("You inputed place of birth not in the data...");
            //}

            /*
             * 
             * GAME ROUNDS AND OTHER LOGIC IMPLEMENTED IN HERE
             * 
             */

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

                //Different code path depending on the choice

                /*
                 * 
                 *  PLAYER MOVEMENT LOGIC HERE
                 * 
                 */


                foreach (var obj in CountriesList)
                {
                    if (choice == obj.NameOfCountry)
                    {
                        playerMovement(obj.NameOfCountry, firstCharacter);
                    }
                }

               

                //int checkForDeaths = Bulgaria.CurrentPopulation + France.CurrentPopulation + US.CurrentPopulation + Germany.CurrentPopulation + Italy.CurrentPopulation;

                //if (firstCharacter.Points == 6)
                //{
                //    //WIN
                //    Console.WriteLine("Well done brave soldier, " + firstCharacter.Name + ", the Presidents have been saved and the world can recover a little easier. The bodyguard was awarded a medal for bravery, a medal for bravery and a medal for devotion.");
                //    Console.WriteLine("Reason for win: You saved all 6 presidents! Congrats!");
                //    break;
                //}
                //else if (checkForDeaths < 100 && firstCharacter.Points < 3)
                //{
                //    //LOSE
                //    Console.WriteLine("Well done to you, brave soldier, you did well, but you failed to save enough presidents.And the world cannot be restored.");
                //    Console.WriteLine("Reason for lose: All people of the world died... Try to save more presidents faster!");
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 3)
                //{
                //    //LOSE
                //    Console.WriteLine("Well done to you, brave soldier, you did well, but you failed to save enough presidents.And the world cannot be restored.");
                //    Console.WriteLine("Reason for lose: All presidents died... Try to save at least 3 presidents faster!");
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points >= 3)
                //{
                //    //WIN
                //    Console.WriteLine("Well done brave soldier, " + firstCharacter.Name + ", the Presidents have been saved and the world can recover a little easier. The bodyguard was awarded a medal for bravery, a medal for bravery and a medal for devotion.");
                //    Console.WriteLine("Reason for win: All presidents died, but you managed to save" + firstCharacter.Points + " presidents!");
                //    break;
                //} //ENDING 1
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" & firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (France.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                //{
                //    break;
                //}
                //else if (Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //} //ENDINGS 2
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" & firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //} // ENDING 3
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                //{
                //    break;
                //}
                //else if (Bulgaria.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                //{
                //    break;
                //}
                //else if (Germany.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                //{
                //    break;
                //}
                //else if (France.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                //{
                //    break;
                //}
                //else if (Italy.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                //{
                //    break;
                //}
                //else if (US.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                //{
                //    break;
                //}



            }
        }
    }
}