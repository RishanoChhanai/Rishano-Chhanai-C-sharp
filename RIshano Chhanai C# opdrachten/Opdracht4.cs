using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Opdracht4
{
    public void Start()
    {
        Console.WriteLine("Wat is jouw geboorte jaar?");
        int jaar = int.Parse(Console.ReadLine());
        Console.WriteLine($"je bent geboren in " + jaar);
        int currentjaar = 2026;
        int leeftijd = currentjaar - jaar;

        if (IsAdult(leeftijd))
        {
            Console.WriteLine("je bent " + leeftijd + " jaar oud. ", "je mag stemmen");
            if (leeftijd >= 21)
            {
                Console.WriteLine("je mag legaal alcohol drinken in america.");
            }
            else if (leeftijd >= 30)
            {
                Console.WriteLine("je mag beginnen met pensioen planning");
            }
            else
            {
                Console.WriteLine("In Amerika op je 40ste/na je 40ste kom je in een programma tegen oudersdom discriminatie.");
            }
        }else
        {
            Console.WriteLine("je bent " + leeftijd + " jaar oud. ");
            Console.WriteLine("je mag niet stemmen");
        }

        
            
        

        bool IsAdult(int age)
        {
            return age >= 18;
        }

        
    }


}