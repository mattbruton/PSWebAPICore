using System.Collections.Generic;
using VSMacAPI.API.Models;

namespace VSMacAPI.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Name = "Nashville",
                    Description = "Music City USA",
                    NumberOfPointsOfInterest = 5
                },
                new City()
                {
                    Id = 2,
                    Name = "Boston",
                    Description = "It's cold.",
                    NumberOfPointsOfInterest = 8
                },
                new City()
                {
                    Id = 3,
                    Name = "New York City",
                    Description = "The Big Apple",
                    NumberOfPointsOfInterest = 12
                }
            };
        }

        public List<City> Cities { get; set; }
    }
}