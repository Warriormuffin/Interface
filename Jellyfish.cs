using System;
namespace Interface
{
    public class Jellyfish : IOrganism
    {
        public string Habitat { get; set; }

        public void Display()
        {
            Console.WriteLine("I am a JellyFish");
        }
    }
}
