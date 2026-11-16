using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIshano_Chhanai_C__opdrachten
{
    public class Opdracht2
    {
        public void Uitvoer()
        {
            Console.WriteLine("Je wordt wakker in je huis. Wat ga je doen? 1. poepen 2. Uit de raam springen 3. Eten maken.");

            int Jos = int.Parse(Console.ReadLine());
            if (Jos == 1)
            {
                Console.WriteLine("Je zit te kakken MAAR er komt een slang uit de wc en bijt je lul eraf.");
            }
            else if (Jos == 2)
            {
                Console.WriteLine("Je valt uit de raam maar valt op iets zacht. Je wint.");
            }
            else if (Jos == 3)
            {
                Console.WriteLine("Je maakt wat eten maar de eten was verrot. je verliest.");
            }
        }
    }
}
