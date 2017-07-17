using System;
namespace Interface
{
    public class Lion : IOrganism
    {
        public string Habitat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.WriteLine("I am a Lion");
        }
    }
}
