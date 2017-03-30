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
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 1,
                            Name = "Music City Center",
                            Description = "It's a place!"
                        },
                        new PointOfInterest()
                        {
                            Id = 2,
                            Name = "Ryman Auditorium",
                            Description = "People play music here."
                        },
                        new PointOfInterest()
                        {
                            Id = 3,
                            Name = "Opry Mills Mall",
                            Description = "Once a theme park, now a shopping mall."
                        }
                    }
                },
                new City()
                {
                    Id = 2,
                    Name = "Boston",
                    Description = "It's cold.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 1,
                            Name = "Freedom Trail",
                            Description = "Go walking."
                        },
                        new PointOfInterest()
                        {
                            Id = 2,
                            Name = "Boston Common",
                            Description = "It's a park."
                        }
                    }
                },
                new City()
                {
                    Id = 3,
                    Name = "New York City",
                    Description = "The Big Apple",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Bring scissors if it's late."
                        },
                        new PointOfInterest()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "It's kinda tall."
                        },
                        new PointOfInterest()
                        {
                            Id = 3,
                            Name = "Statue of Liberty",
                            Description = "Big, green lady."
                        },
                    }
                }
            };
        }

        public List<City> Cities { get; set; }
    }
}