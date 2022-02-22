using System;
using RPG.SRC.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight ("Arus", 23 , "Knight");
            Ninja wedde = new Ninja ("Wedde", 23 , "Ninja");
            Wizard wizard = new Wizard ("Jennica", 23 , "White Wizard");
            BlackWizard blackwizard = new BlackWizard ("Topapa", 23 , "Black Wizard");
            

            
            Console.WriteLine (arus.Attack());
            Console.WriteLine (wizard.Attack(7));
            Console.WriteLine (wedde.Attack());
            Console.WriteLine (blackwizard.Attack());
        }
    }
}
