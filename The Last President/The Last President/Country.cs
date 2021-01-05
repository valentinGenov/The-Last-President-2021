using System;
using System.Collections.Generic;
using System.Text;

namespace The_Last_President
{
    class Country
    {
        private readonly Random _random = new Random();

        private int population;
        private int currentPopulation;
        private string nameOfCountry;
        private string presidentOfCountry;

        public Country() {
            this.population = 1;
            this.currentPopulation = 1;
            this.nameOfCountry = "default";
            this.presidentOfCountry = "default";
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

        public int RandomNumber(int min, int max)  
        {  
            return _random.Next(min, max);  
        }  

        public override string ToString()
        {
            return "Name: " + this.NameOfCountry + " / Population from start: " + this.Population + " / Current population: " + this.CurrentPopulation + " / President: " + this.PresidentOfCountry;
        }
    }
    
}
