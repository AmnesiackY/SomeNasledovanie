using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesCheck
{
    public class Masha : Women
    {
        public override void Run()
        {
            Console.WriteLine("Run Forest, Run");
        }
        public override void Talk()
        {
            Console.WriteLine("Do you have girlfriend?");
        }
        public override void GiveBirth()
        {
            Console.WriteLine("You can pregnant");
        }
        public override void Pregnancy()
        {
            Random rnd = new Random();
            Console.WriteLine($"You have {rnd.Next(1,5)}");
        }
        public void BanjoPlay()
        {
            Console.WriteLine("Ding-dong-ding-dong");
        }
        public void HerdingCows() 
        { 
            Random rnd = new Random();
            Console.WriteLine($"I've got {rnd.Next(3,20)} cows");
        }
    }
}
