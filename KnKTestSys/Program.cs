using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Species> allSpecies = Species.loadSpecies();
            Character test = new Character();
            test.setSpecies("base22", allSpecies);
            Console.WriteLine(test.getSpecies().getName());
            test.setSpecies("base2", allSpecies);
            Console.WriteLine(test.getSpecies().getName());

        }
    }
}
