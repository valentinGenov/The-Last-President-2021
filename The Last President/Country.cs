using System;
using System.Collections.Generic;
using System.Text;

namespace The_Last_President
{
    class Country
    {

        private int population;
        private int currentPopulation;
        private string nameOfCountry;
        private string presidentOfCountry;
        private bool statusOfPresident;

        public Country()
        {
            this.Population = 1;
            this.CurrentPopulation = 1;
            this.NameOfCountry = "default";
            this.PresidentOfCountry = "default";
            this.statusOfPresident = true;
        }

        public Country(int pop, int currPop, string nOC, string pOC, bool sOP)
        {
            this.Population = pop;
            this.CurrentPopulation = currPop;
            this.NameOfCountry = nOC;
            this.PresidentOfCountry = pOC;
            this.StatusOfPresident = sOP;
        }

        public bool StatusOfPresident
        {
            get { return this.statusOfPresident; }
            set { this.statusOfPresident = value; }
        }

        public int Population
        {
            get { return this.population; }
            set { this.population = value; }
        }

        public int CurrentPopulation
        {
            get { return this.currentPopulation; }
            set { this.currentPopulation = value; }
        }

        public string NameOfCountry
        {
            get { return this.nameOfCountry; }
            set { this.nameOfCountry = value; }
        }

        public string PresidentOfCountry
        {
            get { return this.presidentOfCountry; }
            set { this.presidentOfCountry = value; }
        }

        private static readonly Random _random = new Random();

        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public override string ToString()
        {
            return "Name: " + this.NameOfCountry + " / Population from start: " + this.Population + " / Current population: " + this.CurrentPopulation + " / President: " + this.PresidentOfCountry;
        }

        public static void presidentSetUp (string name)
        {
           
        }

        public static void DeathOrNot(Country countries)
        {
            int deathsThisRound1 = countries.Population - countries.CurrentPopulation;

            if (deathsThisRound1 == 0 /*&& i > 1 */)
            {
                if (countries.PresidentOfCountry == "Alive & Not Saved")
                {
                    Console.Write(countries.NameOfCountry + " - " + "Current Population: " + countries.CurrentPopulation);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" +" + deathsThisRound1);
                    Console.ResetColor();

                    Console.Write(" / President status: ");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(countries.PresidentOfCountry);
                    Console.ResetColor();

                    Console.WriteLine("\n");
                }
                else if (countries.PresidentOfCountry == "Alive & Saved")
                {
                    Console.Write(countries.NameOfCountry + " - " + "Current Population: " + countries.CurrentPopulation);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" +" + deathsThisRound1);
                    Console.ResetColor();

                    Console.Write(" / President status: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(countries.PresidentOfCountry);
                    Console.ResetColor();

                    Console.WriteLine("\n");
                }
                else if (countries.PresidentOfCountry == "Death")
                {
                    Console.Write(countries.NameOfCountry + " - " + "Current Population: " + countries.CurrentPopulation);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" +" + deathsThisRound1);
                    Console.ResetColor();

                    Console.Write(" / President status: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(countries.PresidentOfCountry);
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

                if (countries.PresidentOfCountry == "Alive & Not Saved")
                {
                    Console.Write(countries.NameOfCountry + " - " + "Current Population: " + countries.CurrentPopulation);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" -" + deathsThisRound1);
                    Console.ResetColor();

                    Console.Write(" / President status: ");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(countries.PresidentOfCountry);
                    Console.ResetColor();

                    Console.WriteLine("\n");
                }
                else if (countries.PresidentOfCountry == "Alive & Saved")
                {
                    Console.Write(countries.NameOfCountry + " - " + "Current Population: " + countries.CurrentPopulation);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" -" + deathsThisRound1);
                    Console.ResetColor();

                    Console.Write(" / President status: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(countries.PresidentOfCountry);
                    Console.ResetColor();

                    Console.WriteLine("\n");
                }
                else if (countries.PresidentOfCountry == "Death")
                {
                    Console.Write(countries.NameOfCountry + " - " + "Current Population: " + countries.CurrentPopulation);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" -" + deathsThisRound1);
                    Console.ResetColor();

                    Console.Write(" / President status: ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(countries.PresidentOfCountry);
                    Console.ResetColor();

                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("There is an error in the code section for Death and Presidents most likely!");
                }
            }
        }

            public static void playerMovement (Country countries, Character character)
            {
                //Check if you are already in that contry
                if (character.Location == countries.nameOfCountry)
                {
                    Console.WriteLine("You choosed " + countries.NameOfCountry + " do you want to stay another round here?");
                }
                else
                {
                    Console.WriteLine("You choosed " + countries.NameOfCountry + " do you want to move?");
                }

                //Give choice to move or break
                string choiceToContinueBulgaria;
                choiceToContinueBulgaria = Console.ReadLine();

                if (choiceToContinueBulgaria == "y" || choiceToContinueBulgaria == "yes" || choiceToContinueBulgaria == "Yes")
                {
                    //Change location of the player
                    character.Location = countries.NameOfCountry;

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

                        countries.CurrentPopulation -= randDeaths1;
                        countries.CurrentPopulation -= randDeaths2;
                        countries.CurrentPopulation -= randDeaths3;
                        countries.CurrentPopulation -= randDeaths4;
                        countries.CurrentPopulation -= randDeaths5;
                    }
                    else if (randVolume == 2)
                    {
                        int randDeaths1 = Country.RandomNumber(0, 50000);
                        int randDeaths2 = Country.RandomNumber(0, 50000);
                        int randDeaths3 = Country.RandomNumber(0, 50000);
                        int randDeaths4 = Country.RandomNumber(0, 50000);
                        int randDeaths5 = Country.RandomNumber(0, 50000);

                        countries.CurrentPopulation -= randDeaths1;
                        countries.CurrentPopulation -= randDeaths2;
                        countries.CurrentPopulation -= randDeaths3;
                        countries.CurrentPopulation -= randDeaths4;
                        countries.CurrentPopulation -= randDeaths5;
                    }
                    else if (randVolume == 3)
                    {
                        int randDeaths1 = Country.RandomNumber(50000, 4000000);
                        int randDeaths2 = Country.RandomNumber(50000, 4000000);
                        int randDeaths3 = Country.RandomNumber(50000, 4000000);
                        int randDeaths4 = Country.RandomNumber(50000, 4000000);
                        int randDeaths5 = Country.RandomNumber(50000, 4000000);

                        countries.CurrentPopulation -= randDeaths1;
                        countries.CurrentPopulation -= randDeaths2;
                        countries.CurrentPopulation -= randDeaths3;
                        countries.CurrentPopulation -= randDeaths4;
                        countries.CurrentPopulation -= randDeaths5;
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
                        if (countries.PresidentOfCountry == "Alive & Saved")
                        {

                        }
                        else
                        {
                            countries.PresidentOfCountry = "Death";
                        }
                    }
                    if (randDie2 == 1)
                    {
                        if (countries.PresidentOfCountry == "Alive & Saved")
                        {
                            //continue
                        }
                        else
                        {
                            countries.PresidentOfCountry = "Death";
                        }
                    }
                    if (randDie3 == 1)
                    {
                        if (countries.PresidentOfCountry == "Alive & Saved")
                        {
                            //continue
                        }
                        else
                        {
                            countries.PresidentOfCountry = "Death";
                        }
                    }
                    if (randDie4 == 1)
                    {
                        if (countries.PresidentOfCountry == "Alive & Saved")
                        {
                            //continue
                        }
                        else
                        {
                            countries.PresidentOfCountry = "Death";
                        }
                    }
                    if (randDie5 == 1)
                    {
                        if (countries.PresidentOfCountry == "Alive & Saved")
                        {
                            //continue
                        }
                        else
                        {
                            countries.PresidentOfCountry = "Death";
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
                        if (countries.PresidentOfCountry == "Death")
                        {
                            //continue
                        }
                        else if (character.Location == "Bulgaria")
                        {
                            countries.PresidentOfCountry = "Alive & Saved";
                            character.Points++;
                        }
                    }
                    if (randSave2a == 1)
                    {
                        if (countries.PresidentOfCountry == "Death")
                        {
                            //continue
                        }
                        else if (character.Location == "Germany")
                        {
                           countries.PresidentOfCountry = "Alive & Saved";
                            character.Points++;
                        }
                    }
                    if (randSave3a == 1)
                    {
                        if (countries.PresidentOfCountry == "Death")
                        {
                            //continue
                        }
                        else if (character.Location == "France")
                        {
                            countries.PresidentOfCountry = "Alive & Saved";
                            character.Points++;
                        }
                    }
                    if (randSave4a == 1)
                    {
                        if (countries.PresidentOfCountry == "Death")
                        {
                            //continue
                        }
                        else if (character.Location == "Italy")
                        {
                            countries.PresidentOfCountry = "Alive & Saved";
                            character.Points++;
                        }
                    }
                    if (randSave5a == 1)
                    {
                        if (countries.PresidentOfCountry == "Death")
                        {
                            //continue
                        }
                        else if (character.Location == "US")
                        {
                            countries.PresidentOfCountry = "Alive & Saved";
                            character.Points++;
                        }
                    }
                }
                else if (choiceToContinueBulgaria == "n" || choiceToContinueBulgaria == "no" || choiceToContinueBulgaria == "No")
                {
                    //
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
                }
            }
        }
    }
