using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace RIshano_Chhanai_C__opdrachten
{
    public class Opdracht1
    {
        public void Uitvoer()
        {
            Console.WriteLine("Hallo, wat is jouw naam?");
            string Naam = Console.ReadLine();

            Console.WriteLine("Wat is jouw leeftijd?");
            int Leeftijd = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hallo {Naam}, jij bent {Leeftijd} jaar oud!");
            
        }
    }
}
