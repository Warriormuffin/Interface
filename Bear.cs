using System;
namespace Interface
{
    public class Bear : IOrganism
    {
        public string Habitat { get; set; }

        public void Display()
        {
            Console.WriteLine("I am a bear");
        }

        public void Eat()
        {
            Console.WriteLine("You are an idiot, you steped into the bear cage and were mauled to death, your family will not miss you");
        }
    }
}
