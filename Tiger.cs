using System;
namespace Interface
{
    public class Tiger : IOrganism
    {

        public string Habitat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.WriteLine("I am a Tiger! RAWR");
        }
    }
}
