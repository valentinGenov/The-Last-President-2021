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
            this.StatusOfPresident = sOP
        }

        public int StatusOfPresident
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
    }
}
