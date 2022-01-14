using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesCheck
{
    public class Vasya : Men
    {
        public override void Run()
        {
            Console.WriteLine("h-h-h-h-h-h-h-h-h-h");
            Console.WriteLine("Ya ustal, Ya uhoju");
        }
        public override void Talk()
        {
            Console.WriteLine("We can play duo?");
        }
        public override void TwoHemispheres()
        {
            Console.WriteLine("I have a 1st degree in chess");
        }
        public override void Fertilization()
        {
            Console.WriteLine($"You can be father");
        }
        public void WorkOnZavod()
        {
            Random rndm = new Random();
            Console.WriteLine($"I worked a {rndm}-hour shift, I need to sleep!");
        }
        public void DrinkVodkaPlayDotka()
        {
            Random losestreak = new Random();
            Console.WriteLine($"I need to PICK TECHKA! I HAVE LOSESTREAK {losestreak.Next(5,50)}!");
        }
    }
}
