using System;

namespace WebAppTest.Models
{
    public class MasterData
    {
        public int Id { get; set; }
        public string Surname { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public DateTime DateOfBirth	{ get; set; }
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string PlaceOfResidence { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string HealthInsurance { get; set; } = string.Empty;
        public string KvNumber { get; set; } = string.Empty;
        public string ForeignHealthInsurance { get; set; } = string.Empty;
        public string RefugeeStatus { get; set; } = string.Empty;
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}