using System;
using System.Collections.Generic;

namespace Interface
{

    public class Zoo
    {
        private List<IOrganism> organisms;

        public Zoo()
        {
            organisms = new List<IOrganism>();
        }

        public void AddExhibit(IOrganism creature)
        {
            organisms.Add(creature);
            
        }

        public void Display()
        {
            foreach (var animal in organisms)
            {
                animal.Display();
            }
        }
    }
}
