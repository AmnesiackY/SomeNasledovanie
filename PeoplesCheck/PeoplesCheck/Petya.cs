using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesCheck
{
    public class Petya : Men
    {
        public override void Run()
        {
            Console.WriteLine("You ran 5km");
        }
        public override void Talk()
        {
            Console.WriteLine("What's your name?");
        }
        public override void TwoHemispheres()
        {
            Console.WriteLine("You work with 2 hemispheres!");
        }
        public override void Fertilization()
        {
            Console.WriteLine($"You can be father");
        }
        public void Iam()
        {
            Console.WriteLine("My name Petya");
        }
    }
}
