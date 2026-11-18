using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class Opdracht2
{
    public void Start()
    {
        string currentLocation = "slaapkamer";
        bool lost = false;
        string[] locaties = { "slaapkamer", "woonkamer", "gang", "badkamer", "buiten" };

        while (true)
        {

            if (currentLocation == "slaapkamer")
            {
                Console.WriteLine("Je wordt wakker in je slaapkamer. Wat ga je doen?\n1. naar de gang gaan.");
              
            }

            if (currentLocation == "gang")
            {
                Console.WriteLine("Je zit in de gang\n Je ziet de: \nWoonkamer. \nbadkamer. \nbuiten.\nWat ga je doen?");
            }

            if (currentLocation == "badkamer")
            {
                Console.WriteLine("Je gaat douchen maar er komt hantavirus op je af en je gaat dood.");
                Console.WriteLine("Je hebt verloren.");
            }

            if (currentLocation == "buiten")
            {
                Console.WriteLine("Je flikkert uit je raam en beland buiten, gelukkig val je op iets zacht en ben je veilig buiten.");
                Console.WriteLine("Je wint goed gedaan.");
                break;
            }
            if (currentLocation == "woonkamer")
            {
                Console.WriteLine("Je gaat naar de woonkamer alleen je ziet zaag stof en krijgt hart aanval?");
                Console.WriteLine("Je verliest.");
            }

            if (lost)
            {
                Console.WriteLine("\nWil je opnieuw proberen? Typ 'retry' in de terminal");

                string _result = Console.ReadLine().ToLower();
                if (_result == "retry")
                {
                    Console.Clear();
                    lost = false;
                    Start();
                    return;

                }

            }

            string result = Console.ReadLine().ToLower();

            foreach (string locatie in locaties)
            {
                if (result == locatie)
                {

                    if (result == "woonkamer")
                    {
                        lost = true;
                    }

                    if (result == "badkamer")
                    {
                        lost = true;
                    }

                    currentLocation = locatie;
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Je kan niet deze directie, probeer opnieuw.");
                    continue;
                }
            }

        }

    }
}
