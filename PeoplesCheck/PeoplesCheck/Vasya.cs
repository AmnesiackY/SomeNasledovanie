using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesCheck
{
    public class Vasya : Men
    {
        public override void Run()
        {
            Console.WriteLine("You ran 1km");
        }
        public override void Talk()
        {
            Console.WriteLine("We can play duo?");
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
