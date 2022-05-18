using System;
namespace PlayerStats.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }

        public Team() { }

        public Team(int id, string name, City city)
        {
            Id = id;
            Name = name;
            City = city;
        }
    }
}
