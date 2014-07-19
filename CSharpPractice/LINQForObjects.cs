using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPractice
{
    class LINQForObjects
    {
        public LINQForObjects()
        {
            Place p1 = new Place("Googleplex", 12);
            Place p2 = new Place("Adam's House", 5);
            List<Place> listOfPlaces = Place.GetAllPlaces();
            var filtered = from Place p in listOfPlaces where p.numberOfPeopleInThatPlace > 10 select p;
            
            foreach (Place p in filtered)
            {
                Console.WriteLine(p.name);
            }
        }
    }
}
