using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesCheck
{
    public class Masha : Women
    {
        public override void Run()
        {
            Console.WriteLine("You ran 3km");
        }
        public override void Talk()
        {
            Console.WriteLine("What's your name?");
        }
        public override void GiveBirth()
        {
            Console.WriteLine("You can pregnant");
        }
        public override void Pregnancy() 
        {
            Random rnd = new Random();
            Console.WriteLine($"You have {rnd.Next(5)}");
        }
        public void Iam() 
        {
            Console.WriteLine("My name Masha");
        }
    }
}
