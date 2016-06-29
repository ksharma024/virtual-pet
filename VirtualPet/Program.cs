using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        { 
        VirtualPet pet = new VirtualPet();
            while (1 == 1)
            {
                Console.WriteLine("Your Pet Name");
                Console.WriteLine("Hunger: " + pet.Hunger);
                Console.WriteLine("Playfulness: " + pet.Playfulness);
                Console.WriteLine("Energy: " + pet.Energy);
                Console.WriteLine("");

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Walk the pet");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Exit");
                Console.WriteLine("");

                string input = Console.ReadLine();

                    string result = "";

                if (input == "1")
                {
                    result = pet.FeedPet();
                }
                else if (input == "2")
                {
                    result = pet.TakeForWalk();
                }
                else if (input == "3")
                {
                    result = pet.Play();
                }
                else if (input == "4")
                {
                    Console.WriteLine("Goodbye");
                 System.Threading.Thread.Sleep(300);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
                if (!string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("");
                    Console.WriteLine(result);
                }
                Console.WriteLine("");
                pet.Tick();
            }
        }
    }
}