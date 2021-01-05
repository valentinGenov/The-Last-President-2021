using System;
using System.Collections.Generic;
using System.Text;

namespace The_Last_President
{
    class Character
    {
        private string name;
        private string sex;
        private int age;
        private string placeOfBirth;
        private string occupation;

        public Character()
        {
            this.Name = "Character 1";
            this.Sex = "Male";
            this.Age = 21;
            this.PlaceOfBirth = "Bulgaria";
            this.Occupation = "Bodyguard";
        }

        public Character(string n, string s, int a, string po, string occ)
        {
            this.Name = n;
            this.Sex = s;
            this.Age = a;
            this.PlaceOfBirth = po;
            this.Occupation = occ;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { 
                
                if (value == "Female" || value == "Male" || value == "male" || value == "female")
	            {
                    this.sex = value;
	            } else {
                    Console.WriteLine("Sorry! Please choose proper sex (male/female): ");
                }

            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if( value > 0 && value < 90)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("This person is too old! ");
                }
            }
        }

        public string PlaceOfBirth
        {
            get { return this.placeOfBirth; }
            set { this.placeOfBirth = value; }
        }

         public string Occupation
        {
            get { return this.occupation; }
            set { this.occupation = value; }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " " + " Sex: " + this.Sex + " Age: " + this.Age + " placeOfBirth: " + this.placeOfBirth + " Occupation " + this.occupation;
        }
    }
}
