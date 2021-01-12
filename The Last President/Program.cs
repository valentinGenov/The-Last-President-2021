using System;
using System.Reflection;

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
            //Country name = new Country(start population, current population, name, president status, status for logic);
            Country Bulgaria = new Country(6951482, 6951482, "Bulgaria", "Alive & Not Saved", true);
            Country Germany = new Country(83166711, 83166711, "Germany", "Alive & Not Saved", true);
            Country France = new Country(67147000, 67147000, "France", "Alive & Not Saved", true);
            Country Italy = new Country(60317116, 60317116, "Italy", "Alive & Not Saved", true);
            Country US = new Country(328239523, 328239523, "United States", "Alive & Not Saved", true);

            //Making you place of birth country with saved president and adding +1 points.
            if (firstCharacter.PlaceOfBirth == "Bulgaria")
            {
                Bulgaria.PresidentOfCountry = "Alive & Saved";
                Console.WriteLine("Since you choose Bulgaria you automaticaly saved The President Of Bulgaria!");
                firstCharacter.Points++;
            }
            else if (firstCharacter.PlaceOfBirth == "Germany")
            {
                Germany.PresidentOfCountry = "Alive & Saved";
                Console.WriteLine("Since you choose Germany you automaticaly saved The President Of Germany!");
                firstCharacter.Points++;
            }
            else if (firstCharacter.PlaceOfBirth == "France")
            {
                France.PresidentOfCountry = "Alive & Saved";
                Console.WriteLine("Since you choose France you automaticaly saved The President Of France!");
                firstCharacter.Points++;
            }
            else if (firstCharacter.PlaceOfBirth == "Italy")
            {
                Italy.PresidentOfCountry = "Alive & Saved";
                Console.WriteLine("Since you choose Italy you automaticaly saved The President Of Italy");
                firstCharacter.Points++;
            }
            else if (firstCharacter.PlaceOfBirth == "US")
            {
                US.PresidentOfCountry = "Alive & Saved";
                Console.WriteLine("Since you choose United States you automaticaly saved The President Of United States!");
                firstCharacter.Points++;
            }
            else
            {
                Console.WriteLine("You inputed place of birth not in the data...");
            }

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
                 * DEATHS AND PRESIDENTS BULGARIA
                 * 
                 */

                int deathsThisRound1 = Bulgaria.Population - Bulgaria.CurrentPopulation;

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("            Country List            ");

                Console.ResetColor();

                Console.WriteLine("\n");

                if (deathsThisRound1 == 0 /*&& i > 1 */)
                {
                    if (Bulgaria.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(Bulgaria.NameOfCountry + " - " + "Current Population: " + Bulgaria.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound1);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Bulgaria.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Bulgaria.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(Bulgaria.NameOfCountry + " - " + "Current Population: " + Bulgaria.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound1);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Bulgaria.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Bulgaria.PresidentOfCountry == "Death")
                    {
                        Console.Write(Bulgaria.NameOfCountry + " - " + "Current Population: " + Bulgaria.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound1);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Bulgaria.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }

                    Console.WriteLine("\n");
                }
                else
                {

                    if (Bulgaria.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(Bulgaria.NameOfCountry + " - " + "Current Population: " + Bulgaria.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound1);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Bulgaria.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Bulgaria.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(Bulgaria.NameOfCountry + " - " + "Current Population: " + Bulgaria.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound1);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Bulgaria.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Bulgaria.PresidentOfCountry == "Death")
                    {
                        Console.Write(Bulgaria.NameOfCountry + " - " + "Current Population: " + Bulgaria.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound1);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Bulgaria.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }
                }

                /*
                 * 
                 * DEATHS AND PRESIDENTS GERMANY
                 * 
                 */

                int deathsThisRound2 = Germany.Population - Germany.CurrentPopulation;

                if (deathsThisRound2 == 0)
                {
                    if (Germany.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(Germany.NameOfCountry + " - " + "Current Population: " + Germany.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound2);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Germany.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Germany.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(Germany.NameOfCountry + " - " + "Current Population: " + Germany.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound2);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Germany.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Germany.PresidentOfCountry == "Death")
                    {
                        Console.Write(Germany.NameOfCountry + " - " + "Current Population: " + Germany.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound2);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Bulgaria.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }

                    Console.WriteLine("\n");
                }
                else
                {

                    if (Germany.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(Germany.NameOfCountry + " - " + "Current Population: " + Germany.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound2);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Germany.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Germany.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(Germany.NameOfCountry + " - " + "Current Population: " + Germany.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound2);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Germany.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Germany.PresidentOfCountry == "Death")
                    {
                        Console.Write(Germany.NameOfCountry + " - " + "Current Population: " + Germany.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound2);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Germany.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }
                }

                /*
                 * 
                 * DEATHS AND PRESIDENTS FRANCE
                 * 
                 */

                int deathsThisRound3 = France.Population - France.CurrentPopulation;

                if (deathsThisRound3 == 0)
                {
                    if (France.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(France.NameOfCountry + " - " + "Current Population: " + France.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound3);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(France.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (France.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(France.NameOfCountry + " - " + "Current Population: " + France.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound3);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(France.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (France.PresidentOfCountry == "Death")
                    {
                        Console.Write(France.NameOfCountry + " - " + "Current Population: " + France.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound3);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(France.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }

                    Console.WriteLine("\n");
                }
                else
                {

                    if (France.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(France.NameOfCountry + " - " + "Current Population: " + France.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound3);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(France.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (France.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(France.NameOfCountry + " - " + "Current Population: " + France.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound3);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(France.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (France.PresidentOfCountry == "Death")
                    {
                        Console.Write(France.NameOfCountry + " - " + "Current Population: " + France.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound3);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(France.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }
                }

                /*
                 * 
                 * DEATHS AND PRESIDENTS ITALY
                 * 
                 */

                int deathsThisRound4 = Italy.Population - Italy.CurrentPopulation;

                if (deathsThisRound4 == 0)
                {
                    if (Italy.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(Italy.NameOfCountry + " - " + "Current Population: " + Italy.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound4);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Italy.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Italy.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(Italy.NameOfCountry + " - " + "Current Population: " + Italy.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound4);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Italy.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Italy.PresidentOfCountry == "Death")
                    {
                        Console.Write(Italy.NameOfCountry + " - " + "Current Population: " + Italy.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound4);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Italy.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }

                    Console.WriteLine("\n");
                }
                else
                {

                    if (Italy.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(Italy.NameOfCountry + " - " + "Current Population: " + Italy.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound4);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(Italy.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Italy.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(Italy.NameOfCountry + " - " + "Current Population: " + Italy.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound4);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Italy.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (Italy.PresidentOfCountry == "Death")
                    {
                        Console.Write(Italy.NameOfCountry + " - " + "Current Population: " + Italy.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound4);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Italy.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }
                }

                /*
                 * 
                 * DEATHS AND PRESIDENTS USA
                 * 
                 */

                int deathsThisRound5 = US.Population - US.CurrentPopulation;

                if (deathsThisRound5 == 0)
                {

                    if (US.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(US.NameOfCountry + " - " + "Current Population: " + US.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound5);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(US.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (US.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(US.NameOfCountry + " - " + "Current Population: " + US.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound5);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(US.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (US.PresidentOfCountry == "Death")
                    {
                        Console.Write(US.NameOfCountry + " - " + "Current Population: " + US.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" +" + deathsThisRound5);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(US.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }

                    Console.WriteLine("\n");
                }
                else
                {

                    if (US.PresidentOfCountry == "Alive & Not Saved")
                    {
                        Console.Write(US.NameOfCountry + " - " + "Current Population: " + US.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound5);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(US.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (US.PresidentOfCountry == "Alive & Saved")
                    {
                        Console.Write(US.NameOfCountry + " - " + "Current Population: " + US.CurrentPopulation);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound5);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(US.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else if (US.PresidentOfCountry == "Death")
                    {
                        Console.Write(US.NameOfCountry + " - " + "Current Population: " + US.CurrentPopulation);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" -" + deathsThisRound5);
                        Console.ResetColor();

                        Console.Write(" / President status: ");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(US.PresidentOfCountry);
                        Console.ResetColor();

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                    }
                }
                Console.WriteLine("Which country would you like to go to?");

                string choice = Console.ReadLine();

                Console.WriteLine("\n");

                //Different code path depending on the choice

                /*
                 * 
                 *  BULGARIA LOGIC HERE
                 * 
                 */
                switch (choice)
                {
                    case "Bulgaria":

                        //Check if you are already in that contry
                        if (firstCharacter.Location == "Bulgaria")
                        {
                            Console.WriteLine("You choosed " + Bulgaria.NameOfCountry + " do you want to stay another round here?");
                        }
                        else
                        {
                            Console.WriteLine("You choosed " + Bulgaria.NameOfCountry + " do you want to move?");
                        }

                        //Give choice to move or break
                        string choiceToContinueBulgaria;
                        choiceToContinueBulgaria = Console.ReadLine();

                        if (choiceToContinueBulgaria == "y" || choiceToContinueBulgaria == "yes" || choiceToContinueBulgaria == "Yes")
                        {
                            //Change location of the player
                            firstCharacter.Location = "Bulgaria";

                            //We make 3 dead volumes and they are choosed randomly... low(0-1000), meidum(0-50000), high(50000-4000000)

                            int randVolume = Country.RandomNumber(1, 3);
                            if (randVolume == 1)
                            {
                                //LOW VOLUME
                                int randDeaths1 = Country.RandomNumber(0, 1000);
                                int randDeaths2 = Country.RandomNumber(0, 1000);
                                int randDeaths3 = Country.RandomNumber(0, 1000);
                                int randDeaths4 = Country.RandomNumber(0, 1000);
                                int randDeaths5 = Country.RandomNumber(0, 1000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 2)
                            {
                                int randDeaths1 = Country.RandomNumber(0, 50000);
                                int randDeaths2 = Country.RandomNumber(0, 50000);
                                int randDeaths3 = Country.RandomNumber(0, 50000);
                                int randDeaths4 = Country.RandomNumber(0, 50000);
                                int randDeaths5 = Country.RandomNumber(0, 50000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 3)
                            {
                                int randDeaths1 = Country.RandomNumber(50000, 4000000);
                                int randDeaths2 = Country.RandomNumber(50000, 4000000);
                                int randDeaths3 = Country.RandomNumber(50000, 4000000);
                                int randDeaths4 = Country.RandomNumber(50000, 4000000);
                                int randDeaths5 = Country.RandomNumber(50000, 4000000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }

                            //President being dead or saved logic
                            //1. Being dead or not

                            int randDie1 = Country.RandomNumber(1, 6);
                            int randDie2 = Country.RandomNumber(1, 6);
                            int randDie3 = Country.RandomNumber(1, 6);
                            int randDie4 = Country.RandomNumber(1, 6);
                            int randDie5 = Country.RandomNumber(1, 6);
                            if (randDie1 == 1)
                            {
                                if (Bulgaria.PresidentOfCountry == "Alive & Saved")
                                {

                                }
                                else
                                {
                                    Bulgaria.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie2 == 1)
                            {
                                if (Germany.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Germany.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie3 == 1)
                            {
                                if (France.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    France.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie4 == 1)
                            {
                                if (Italy.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Italy.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie5 == 1)
                            {
                                if (US.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    US.PresidentOfCountry = "Death";
                                }
                            }


                            //2. Being saved or not if not dead already
                            int randSave1a = Country.RandomNumber(1, 3);
                            int randSave2a = Country.RandomNumber(1, 3);
                            int randSave3a = Country.RandomNumber(1, 3);
                            int randSave4a = Country.RandomNumber(1, 3);
                            int randSave5a = Country.RandomNumber(1, 3);

                            if (randSave1a == 1)
                            {
                                if (Bulgaria.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Bulgaria")
                                {
                                    Bulgaria.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave2a == 1)
                            {
                                if (Germany.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Germany")
                                {
                                    Germany.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave3a == 1)
                            {
                                if (France.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "France")
                                {
                                    France.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave4a == 1)
                            {
                                if (Italy.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Italy")
                                {
                                    Italy.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave5a == 1)
                            {
                                if (US.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "US")
                                {
                                    US.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                        }
                        else if (choiceToContinueBulgaria == "n" || choiceToContinueBulgaria == "no" || choiceToContinueBulgaria == "No")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("There was a problem, somewhere!");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            break;
                        }
                        break;

                    /*
                     * 
                     *  GERMANY LOGIC HERE
                     * 
                     */
                    case "Germany":

                        //Check if you are already in that contry
                        if (firstCharacter.Location == "Germany")
                        {
                            Console.WriteLine("You choosed " + Germany.NameOfCountry + " do you want to stay another round here?");
                        }
                        else
                        {
                            Console.WriteLine("You choosed " + Germany.NameOfCountry + " do you want to move?");
                        }

                        //Give choice to move or break
                        string choiceToContinueGermany;
                        choiceToContinueGermany = Console.ReadLine();

                        if (choiceToContinueGermany == "y" || choiceToContinueGermany == "yes" || choiceToContinueGermany == "Yes")
                        {
                            //Change location of the player
                            firstCharacter.Location = "Germany";

                            //We make 3 dead volumes and they are choosed randomly... low(0-1000), meidum(0-50000), high(50000-4000000)

                            int randVolume = Country.RandomNumber(1, 3);
                            if (randVolume == 1)
                            {
                                //LOW VOLUME
                                int randDeaths1 = Country.RandomNumber(0, 1000);
                                int randDeaths2 = Country.RandomNumber(0, 1000);
                                int randDeaths3 = Country.RandomNumber(0, 1000);
                                int randDeaths4 = Country.RandomNumber(0, 1000);
                                int randDeaths5 = Country.RandomNumber(0, 1000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 2)
                            {
                                int randDeaths1 = Country.RandomNumber(0, 50000);
                                int randDeaths2 = Country.RandomNumber(0, 50000);
                                int randDeaths3 = Country.RandomNumber(0, 50000);
                                int randDeaths4 = Country.RandomNumber(0, 50000);
                                int randDeaths5 = Country.RandomNumber(0, 50000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 3)
                            {
                                int randDeaths1 = Country.RandomNumber(50000, 4000000);
                                int randDeaths2 = Country.RandomNumber(50000, 4000000);
                                int randDeaths3 = Country.RandomNumber(50000, 4000000);
                                int randDeaths4 = Country.RandomNumber(50000, 4000000);
                                int randDeaths5 = Country.RandomNumber(50000, 4000000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                        }
                        else if (choiceToContinueGermany == "n" || choiceToContinueGermany == "no" || choiceToContinueGermany == "No")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("There was a problem, somewhere!");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            break;
                        }

                        //President being dead or saved logic
                        //1. Being dead or not

                        int randDie1G = Country.RandomNumber(1, 6);
                        int randDie2G = Country.RandomNumber(1, 6);
                        int randDie3G = Country.RandomNumber(1, 6);
                        int randDie4G = Country.RandomNumber(1, 6);
                        int randDie5G = Country.RandomNumber(1, 6);
                        if (randDie1G == 1)
                        {
                            if (Bulgaria.PresidentOfCountry == "Alive & Saved")
                            {
                                //continue
                            }
                            else
                            {
                                Bulgaria.PresidentOfCountry = "Death";
                            }
                        }
                        if (randDie2G == 1)
                        {
                            if (Germany.PresidentOfCountry == "Alive & Saved")
                            {
                                //continue
                            }
                            else
                            {
                                Germany.PresidentOfCountry = "Death";
                            }
                        }
                        if (randDie3G == 1)
                        {
                            if (France.PresidentOfCountry == "Alive & Saved")
                            {
                                //continue
                            }
                            else
                            {
                                France.PresidentOfCountry = "Death";
                            }
                        }
                        if (randDie4G == 1)
                        {
                            if (Italy.PresidentOfCountry == "Alive & Saved")
                            {
                                //continue
                            }
                            else
                            {
                                Italy.PresidentOfCountry = "Death";
                            }
                        }
                        if (randDie5G == 1)
                        {
                            if (US.PresidentOfCountry == "Alive & Saved")
                            {
                                //continue
                            }
                            else
                            {
                                US.PresidentOfCountry = "Death";
                            }
                        }

                        //2. Being saved or not if not dead already
                        int randSave1G = Country.RandomNumber(1, 3);
                        int randSave2G = Country.RandomNumber(1, 3);
                        int randSave3G = Country.RandomNumber(1, 3);
                        int randSave4G = Country.RandomNumber(1, 3);
                        int randSave5G = Country.RandomNumber(1, 3);

                        if (randSave1G == 1)
                        {
                            if (Bulgaria.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "Bulgaria")
                            {
                                Bulgaria.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave2G == 1)
                        {
                            if (Germany.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "Germany")
                            {
                                Germany.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave3G == 1)
                        {
                            if (France.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "France")
                            {
                                France.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave4G == 1)
                        {
                            if (Italy.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "Italy")
                            {
                                Italy.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave5G == 1)
                        {
                            if (US.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "US")
                            {
                                US.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        else if (choiceToContinueGermany == "n" || choiceToContinueGermany == "no" || choiceToContinueGermany == "No")
                        {
                            break;
                        }
                        break;

                    /*
                    * 
                    *  FRANCE LOGIC HERE
                    * 
                    */
                    case "France":

                        //Check if you are already in that contry
                        if (firstCharacter.Location == "France")
                        {
                            Console.WriteLine("You choosed " + France.NameOfCountry + " do you want to stay another round here?");
                        }
                        else
                        {
                            Console.WriteLine("You choosed " + France.NameOfCountry + " do you want to move?");
                        }

                        //Give choice to move or break
                        string choiceToContinueFrance;
                        choiceToContinueFrance = Console.ReadLine();

                        if (choiceToContinueFrance == "y" || choiceToContinueFrance == "yes" || choiceToContinueFrance == "Yes")
                        {
                            //Change location of the player
                            firstCharacter.Location = "France";

                            //We make 3 dead volumes and they are choosed randomly... low(0-1000), meidum(0-50000), high(50000-4000000)

                            int randVolume = Country.RandomNumber(1, 3);
                            if (randVolume == 1)
                            {
                                //LOW VOLUME
                                int randDeaths1 = Country.RandomNumber(0, 1000);
                                int randDeaths2 = Country.RandomNumber(0, 1000);
                                int randDeaths3 = Country.RandomNumber(0, 1000);
                                int randDeaths4 = Country.RandomNumber(0, 1000);
                                int randDeaths5 = Country.RandomNumber(0, 1000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 2)
                            {
                                int randDeaths1 = Country.RandomNumber(0, 50000);
                                int randDeaths2 = Country.RandomNumber(0, 50000);
                                int randDeaths3 = Country.RandomNumber(0, 50000);
                                int randDeaths4 = Country.RandomNumber(0, 50000);
                                int randDeaths5 = Country.RandomNumber(0, 50000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 3)
                            {
                                int randDeaths1 = Country.RandomNumber(50000, 4000000);
                                int randDeaths2 = Country.RandomNumber(50000, 4000000);
                                int randDeaths3 = Country.RandomNumber(50000, 4000000);
                                int randDeaths4 = Country.RandomNumber(50000, 4000000);
                                int randDeaths5 = Country.RandomNumber(50000, 4000000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }

                            //President being dead or saved logic
                            //1. Being dead or not

                            int randDie1 = Country.RandomNumber(1, 6);
                            int randDie2 = Country.RandomNumber(1, 6);
                            int randDie3 = Country.RandomNumber(1, 6);
                            int randDie4 = Country.RandomNumber(1, 6);
                            int randDie5 = Country.RandomNumber(1, 6);
                            if (randDie1 == 1)
                            {
                                if (Bulgaria.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Bulgaria.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie2 == 1)
                            {
                                if (Germany.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Germany.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie3 == 1)
                            {
                                if (France.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    France.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie4 == 1)
                            {
                                if (Italy.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Italy.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie5 == 1)
                            {
                                if (US.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    US.PresidentOfCountry = "Death";
                                }
                            }

                            //2. Being saved or not if not dead already
                            int randSave1b = Country.RandomNumber(1, 3);
                            int randSave2b = Country.RandomNumber(1, 3);
                            int randSave3b = Country.RandomNumber(1, 3);
                            int randSave4b = Country.RandomNumber(1, 3);
                            int randSave5b = Country.RandomNumber(1, 3);

                            if (randSave1b == 1)
                            {
                                if (Bulgaria.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Bulgaria")
                                {
                                    Bulgaria.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave2b == 1)
                            {
                                if (Germany.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Germany")
                                {
                                    Germany.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave3b == 1)
                            {
                                if (France.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "France")
                                {
                                    France.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave4b == 1)
                            {
                                if (Italy.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Italy")
                                {
                                    Italy.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave5b == 1)
                            {
                                if (US.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "US")
                                {
                                    US.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                        }
                        else if (choiceToContinueFrance == "n" || choiceToContinueFrance == "no" || choiceToContinueFrance == "No")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("There was a problem, somewhere!");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            break;
                        }
                        break;
                    /*
                                * 
                                *  ITALY LOGIC HERE
                                * 
                                */
                    case "Italy":

                        //Check if you are already in that contry
                        if (firstCharacter.Location == "Italy")
                        {
                            Console.WriteLine("You choosed " + Italy.NameOfCountry + " do you want to stay another round here?");
                        }
                        else
                        {
                            Console.WriteLine("You choosed " + Italy.NameOfCountry + " do you want to move?");
                        }

                        //Give choice to move or break
                        string choiceToContinueItaly;
                        choiceToContinueItaly = Console.ReadLine();

                        if (choiceToContinueItaly == "y" || choiceToContinueItaly == "yes" || choiceToContinueItaly == "Yes")
                        {
                            //Change location of the player
                            firstCharacter.Location = "Italy";

                            //We make 3 dead volumes and they are choosed randomly... low(0-1000), meidum(0-50000), high(50000-4000000)

                            int randVolume = Country.RandomNumber(1, 3);
                            if (randVolume == 1)
                            {
                                //LOW VOLUME
                                int randDeaths1 = Country.RandomNumber(0, 1000);
                                int randDeaths2 = Country.RandomNumber(0, 1000);
                                int randDeaths3 = Country.RandomNumber(0, 1000);
                                int randDeaths4 = Country.RandomNumber(0, 1000);
                                int randDeaths5 = Country.RandomNumber(0, 1000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 2)
                            {
                                int randDeaths1 = Country.RandomNumber(0, 50000);
                                int randDeaths2 = Country.RandomNumber(0, 50000);
                                int randDeaths3 = Country.RandomNumber(0, 50000);
                                int randDeaths4 = Country.RandomNumber(0, 50000);
                                int randDeaths5 = Country.RandomNumber(0, 50000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 3)
                            {
                                int randDeaths1 = Country.RandomNumber(50000, 4000000);
                                int randDeaths2 = Country.RandomNumber(50000, 4000000);
                                int randDeaths3 = Country.RandomNumber(50000, 4000000);
                                int randDeaths4 = Country.RandomNumber(50000, 4000000);
                                int randDeaths5 = Country.RandomNumber(50000, 4000000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }

                            //President being dead or saved logic
                            //1. Being dead or not

                            int randDie1 = Country.RandomNumber(1, 6);
                            int randDie2 = Country.RandomNumber(1, 6);
                            int randDie3 = Country.RandomNumber(1, 6);
                            int randDie4 = Country.RandomNumber(1, 6);
                            int randDie5 = Country.RandomNumber(1, 6);
                            if (randDie1 == 1)
                            {
                                if (Bulgaria.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Bulgaria.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie2 == 1)
                            {
                                if (Germany.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Germany.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie3 == 1)
                            {
                                if (France.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    France.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie4 == 1)
                            {
                                if (Italy.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Italy.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie5 == 1)
                            {
                                if (US.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    US.PresidentOfCountry = "Death";
                                }
                            }

                            //2. Being saved or not if not dead already
                            int randSave1c = Country.RandomNumber(1, 3);
                            int randSave2c = Country.RandomNumber(1, 3);
                            int randSave3c = Country.RandomNumber(1, 3);
                            int randSave4c = Country.RandomNumber(1, 3);
                            int randSave5c = Country.RandomNumber(1, 3);

                            if (randSave1c == 1)
                            {
                                if (Bulgaria.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Bulgaria")
                                {
                                    Bulgaria.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave2c == 1)
                            {
                                if (Germany.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Germany")
                                {
                                    Germany.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave3c == 1)
                            {
                                if (France.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "France")
                                {
                                    France.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave4c == 1)
                            {
                                if (Italy.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "Italy")
                                {
                                    Italy.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                            if (randSave5c == 1)
                            {
                                if (US.PresidentOfCountry == "Death")
                                {
                                    //continue
                                }
                                else if (firstCharacter.Location == "US")
                                {
                                    US.PresidentOfCountry = "Alive & Saved";
                                    firstCharacter.Points++;
                                }
                            }
                        }
                        else if (choiceToContinueItaly == "n" || choiceToContinueItaly == "no" || choiceToContinueItaly == "No")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("There was a problem, somewhere!");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            break;
                        }
                        break;

                    /*
                     * 
                     *  USA LOGIC HERE
                     * 
                     */

                    case "US":

                        //Check if you are already in that contry
                        if (firstCharacter.Location == "US")
                        {
                            Console.WriteLine("You choosed " + US.NameOfCountry + " do you want to stay another round here?");
                        }
                        else
                        {
                            Console.WriteLine("You choosed " + US.NameOfCountry + " do you want to move?");
                        }

                        //Give choice to move or break
                        string choiceToContinueUS;
                        choiceToContinueUS = Console.ReadLine();

                        if (choiceToContinueUS == "y" || choiceToContinueUS == "yes" || choiceToContinueUS == "Yes")
                        {
                            //Change location of the player
                            firstCharacter.Location = "US";

                            //We make 3 dead volumes and they are choosed randomly... low(0-1000), meidum(0-50000), high(50000-4000000)

                            int randVolume = Country.RandomNumber(1, 3);
                            if (randVolume == 1)
                            {
                                //LOW VOLUME
                                int randDeaths1 = Country.RandomNumber(0, 1000);
                                int randDeaths2 = Country.RandomNumber(0, 1000);
                                int randDeaths3 = Country.RandomNumber(0, 1000);
                                int randDeaths4 = Country.RandomNumber(0, 1000);
                                int randDeaths5 = Country.RandomNumber(0, 1000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 2)
                            {
                                int randDeaths1 = Country.RandomNumber(0, 50000);
                                int randDeaths2 = Country.RandomNumber(0, 50000);
                                int randDeaths3 = Country.RandomNumber(0, 50000);
                                int randDeaths4 = Country.RandomNumber(0, 50000);
                                int randDeaths5 = Country.RandomNumber(0, 50000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }
                            else if (randVolume == 3)
                            {
                                int randDeaths1 = Country.RandomNumber(50000, 4000000);
                                int randDeaths2 = Country.RandomNumber(50000, 4000000);
                                int randDeaths3 = Country.RandomNumber(50000, 4000000);
                                int randDeaths4 = Country.RandomNumber(50000, 4000000);
                                int randDeaths5 = Country.RandomNumber(50000, 4000000);

                                Bulgaria.CurrentPopulation -= randDeaths1;
                                Germany.CurrentPopulation -= randDeaths2;
                                France.CurrentPopulation -= randDeaths3;
                                Italy.CurrentPopulation -= randDeaths4;
                                US.CurrentPopulation -= randDeaths5;
                            }

                            //President being dead or saved logic
                            //1. Being dead or not

                            int randDie1 = Country.RandomNumber(1, 6);
                            int randDie2 = Country.RandomNumber(1, 6);
                            int randDie3 = Country.RandomNumber(1, 6);
                            int randDie4 = Country.RandomNumber(1, 6);
                            int randDie5 = Country.RandomNumber(1, 6);
                            if (randDie1 == 1)
                            {
                                if (Bulgaria.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Bulgaria.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie2 == 1)
                            {
                                if (Germany.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Germany.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie3 == 1)
                            {
                                if (France.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    France.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie4 == 1)
                            {
                                if (Italy.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    Italy.PresidentOfCountry = "Death";
                                }
                            }
                            if (randDie5 == 1)
                            {
                                if (US.PresidentOfCountry == "Alive & Saved")
                                {
                                    //continue
                                }
                                else
                                {
                                    US.PresidentOfCountry = "Death";
                                }
                            }
                        }

                        //2. Being saved or not if not dead already
                        int randSave1 = Country.RandomNumber(1, 3);
                        int randSave2 = Country.RandomNumber(1, 3);
                        int randSave3 = Country.RandomNumber(1, 3);
                        int randSave4 = Country.RandomNumber(1, 3);
                        int randSave5 = Country.RandomNumber(1, 3);

                        if (randSave1 == 1)
                        {
                            if (Bulgaria.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "Bulgaria")
                            {
                                Bulgaria.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave2 == 1)
                        {
                            if (Germany.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "Germany")
                            {
                                Germany.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave3 == 1)
                        {
                            if (France.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "France")
                            {
                                France.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave4 == 1)
                        {
                            if (Italy.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "Italy")
                            {
                                Italy.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        if (randSave5 == 1)
                        {
                            if (US.PresidentOfCountry == "Death")
                            {
                                //continue
                            }
                            else if (firstCharacter.Location == "US")
                            {
                                US.PresidentOfCountry = "Alive & Saved";
                                firstCharacter.Points++;
                            }
                        }
                        else if (choiceToContinueUS == "n" || choiceToContinueUS == "no" || choiceToContinueUS == "No")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("There was a problem, somewhere!");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            break;
                        }
                        break;

                        // CHECK END OF THE GAME

                }

                int checkForDeaths = Bulgaria.CurrentPopulation + France.CurrentPopulation + US.CurrentPopulation + Germany.CurrentPopulation + Italy.CurrentPopulation;

                if (firstCharacter.Points == 6)
                {
                    //WIN
                    Console.WriteLine("Well done brave soldier, " + firstCharacter.Name + ", the Presidents have been saved and the world can recover a little easier. The bodyguard was awarded a medal for bravery, a medal for bravery and a medal for devotion.");
                    Console.WriteLine("Reason for win: You saved all 6 presidents! Congrats!");
                    break;
                }
                else if (checkForDeaths < 100 && firstCharacter.Points < 3)
                {
                    //LOSE
                    Console.WriteLine("Well done to you, brave soldier, you did well, but you failed to save enough presidents.And the world cannot be restored.");
                    Console.WriteLine("Reason for lose: All people of the world died... Try to save more presidents faster!");
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 3)
                {
                    //LOSE
                    Console.WriteLine("Well done to you, brave soldier, you did well, but you failed to save enough presidents.And the world cannot be restored.");
                    Console.WriteLine("Reason for lose: All presidents died... Try to save at least 3 presidents faster!");
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points >= 3)
                {
                    //WIN
                    Console.WriteLine("Well done brave soldier, " + firstCharacter.Name + ", the Presidents have been saved and the world can recover a little easier. The bodyguard was awarded a medal for bravery, a medal for bravery and a medal for devotion.");
                    Console.WriteLine("Reason for win: All presidents died, but you managed to save" + firstCharacter.Points + " presidents!");
                    break;
                } //ENDING 1
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                {
                    break;
                }
                else if (Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" & firstCharacter.Points < 1)
                {
                    break;
                }
                else if (France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                {
                    break;
                }
                else if (Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                {
                    break;
                }
                else if (Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                {
                    break;
                }
                else if (France.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 1)
                {
                    break;
                }
                else if (Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                } //ENDINGS 2
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" & firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                } // ENDING 3
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && US.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && Germany.PresidentOfCountry == "Death" && France.PresidentOfCountry == "Death" && Italy.PresidentOfCountry == "Death" && firstCharacter.Points < 2)
                {
                    break;
                }
                else if (Bulgaria.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                {
                    break;
                }
                else if (Germany.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                {
                    break;
                }
                else if (France.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                {
                    break;
                }
                else if (Italy.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                {
                    break;
                }
                else if (US.PresidentOfCountry == "Death" && firstCharacter.Points == 4)
                {
                    break;
                }



            }
        }
    }
}