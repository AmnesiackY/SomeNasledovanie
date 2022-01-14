using System;
using System.Collections.Generic;
using System.Text;

namespace PeoplesCheck
{
    public class Petya : Men
    {
        public override void Run()
        {
            Console.WriteLine("I'm going to run the Tokyo Autumn Marathon, want to come?");
        }
        public override void Talk()
        {
            Console.WriteLine("How much water do you drink?");
        }
        public override void TwoHemispheres()
        {
            Console.WriteLine("I've read the entire Jules Verne collection");
        }
        public override void Fertilization()
        {
            Console.WriteLine($"You cannot be father");
        }
        public void TrainingGym()
        {
            Console.WriteLine("I'll be doing a back complex today");
        }
        public void Meditation()
        {
            Console.WriteLine("OMMMMMMMMMM-OMMMMMMMMMMM-OMMMMMMM");
        }
    }
}
