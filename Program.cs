using System;

namespace Interface
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var zoo = new Zoo();
            var bear = new Bear();

            zoo.AddExhibit(new Bear());
            zoo.AddExhibit(new Jellyfish());
            zoo.AddExhibit(new Tiger());
            zoo.AddExhibit(new Peacock());
            zoo.AddExhibit(new Lion());

            zoo.Display();

            var playing = true;

            while(playing)
            {
                

            Console.WriteLine("What animal would you like to visit? Type in the name of the animal");
            var answer = Console.ReadLine();


            if(answer == "Bear" || answer == "bear" || answer == "BEAR")
            {
                bear.Eat();
                
            }

			}

        }
    }
}
