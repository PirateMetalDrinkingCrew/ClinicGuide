using System;

namespace WebAppTest.Models
{
    public class MasterData
    {
        public int Id { get; set; }
        public Language LanguageId { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string DateOfBirth	{ get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PlaceOfResidence { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string HealthInsurance { get; set; }
        public string KvNumber { get; set; }
        public string ForeignHealthInsurance { get; set; }
        public string RefugeeStatus { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
    }
}