using System;
namespace PlayerStats.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
    }
}
