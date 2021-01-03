using System;

namespace The_Last_President
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Sex (Male or Female): ");
            string sex = Console.ReadLine();

            Console.WriteLine("Enter the Age: ");
            int age = Int32.Parse(Console.ReadLine());

            Character firstCharacter = new Character(name, sex, age);
            Console.WriteLine(firstCharacter);

            Console.WriteLine();
            Console.WriteLine();

            if (sex == "male" || sex == "Male")
            {
                Console.WriteLine("The two presidents gathered to talk about their military power. At one time a president falls to the ground with a high fever and difficulty breathing and snuggle bouquet.Immediately evacuated another president and start Studies have body president. It soon became clear that he had been infected with the Covid-19.");
                Console.WriteLine("The president decides to leave his country.He wonders who will choose to be with him as a bodyguard and decides to choose you.");
                Console.WriteLine("The President: If someone has to be my bodyguard, I prefer it to be you.");
            }
            else
            {
                Console.WriteLine("The two presidents gathered to talk about their military power. At one time a president falls to the ground with a high fever and difficulty breathing and snuggle bouquet.Immediately evacuated another president and start Studies have body president. It soon became clear that he had been infected with the Covid-19.");
                Console.WriteLine("The president decides to leave his country.He wonders who will choose to be with him as a bodyguard and decides to choose you.");
                Console.WriteLine("The President: If someone has to be my bodyguard, I prefer it to be you.");
            }
        }
    }
}
