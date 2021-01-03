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

        public Character(string n, string s, int a)
        {
            this.Name = n;
            this.Sex = s;
            this.Age = a;
            this.placeOfBirth = "Japan";
            this.occupation = "Soldier(BodyGuard)";
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
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
                    Console.WriteLine("This person is very old! ");
                }
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + " " + " Sex: " + this.Sex + " Age: " + this.Age + " placeOfBirth: " + this.placeOfBirth + " Occupation " + this.occupation;
        }
    }
}
