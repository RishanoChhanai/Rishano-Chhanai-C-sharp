using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht3
{
    public void Start()
    {
        Console.WriteLine("wat voor weer is het? \nzonnig. \nbewolkt. \nregen");
        string antwoord = Console.ReadLine();
        if (antwoord == "zonnig" || antwoord == "bewolkt" || antwoord == "regen")
        {
            Console.WriteLine("Wat voor temperatuur is het?");
            if (int.TryParse(Console.ReadLine(), out int temp))


            {

                if (temp > 20 && antwoord == "zonnig")
                {
                    Console.WriteLine("Het is warm, je hoeft geen jas aan. Drink genoeg water!");
                }
                if (temp > 20 && antwoord == "bewolkt")
                {
                    Console.WriteLine("Doe een dunne jas aan want het kan mogelijk regenen");
                }
                if (temp > 20 && antwoord == "regen")
                {
                    Console.WriteLine("Doe nogsteeds een jas aan want het regent en anders een paraplu.");
                }

                else
                    Console.WriteLine("Doe een jas aan want het is best koud");
            }

        }
    }

   
}