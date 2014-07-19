using System;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Place
    {
        // Static List<T> to hold all the places
        private static List<Place> allPlaces = new List<Place>();

        // Instance members
        public string name;
        public int numberOfPeopleInThatPlace = 0; // stupid but for practice
        public DateTime theDateThePlaceWasCreated;

        // Constructor
        public Place(string name, int numberOfPeopleInThatPlace)
        {
            this.name = name;
            this.numberOfPeopleInThatPlace = numberOfPeopleInThatPlace;
            theDateThePlaceWasCreated = DateTime.Today;
            allPlaces.Add(this); // add to static collection
        }

        // Static accessor returns list of all places
        public static List<Place> GetAllPlaces() {
            return allPlaces;
        }
    }
}
