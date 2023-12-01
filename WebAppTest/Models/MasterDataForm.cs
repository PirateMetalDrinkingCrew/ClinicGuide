using System;

namespace WebAppTest.Models
{
    public class MasterDataForm
    {
        public int Id { get; set; }
        public string Headline { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string DateOfBirth	{ get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string PlaceOfResidence { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string HealthInsurance { get; set; } = string.Empty;
        public string KvNumber { get; set; } = string.Empty;
        public string ForeignHealthInsurance { get; set; } = string.Empty;
        public string RefugeeStatus { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public virtual Language LanguageId { get; set; } = null!;
    }
}