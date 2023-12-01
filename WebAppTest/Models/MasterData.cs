using System;

namespace WebAppTest.Models
{
    public class MasterData
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth	{ get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PlaceOfResidence { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string HealthInsurance { get; set; }
        public string KvNumber { get; set; }
        public string ForeignHealthInsurance { get; set; }
        public string RefugeeStatus { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}