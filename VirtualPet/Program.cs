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
        VirtualPet pet = new VirtualPet();
            while (1 == 1)
            {
                Console.WriteLine("Your Pet Name");
                Console.WriteLine("Hunger: " + pet.Hunger);
                Console.WriteLine("Playfulness: " + pet.Playfulness);
                Console.WriteLine("Energy: " + pet.Energy);
                Console.WriteLine("");