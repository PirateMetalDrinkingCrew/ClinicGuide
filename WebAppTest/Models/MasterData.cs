using System;

namespace WebAppTest.Models
{
    public class MasterData
    {
        public int Id { get; set; }
        public Guid PersonGUID { get; set; } = Guid.NewGuid();
        public Language LanguageId { get; set; } = null!;
        public string Surname { get; set; } = string.Empty;
        public string SurnameLabel { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string FirstNameLabel { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string DateOfBirthLabel { get; set; }
        public string Street { get; set; } = string.Empty;
        public string StreetLabel { get; set; } = string.Empty;
        public string HouseNumber { get; set; } = string.Empty;
        public string HouseNumberLabel { get; set; } = string.Empty;
        public string PlaceOfResidence { get; set; } = string.Empty;
        public string PlaceOfResidenceLabel { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string NationalityLabel { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string GenderLabel { get; set; } = string.Empty;
        public string HealthInsurance { get; set; } = string.Empty;
        public string HealthInsuranceLabel { get; set; } = string.Empty;
        public string KvNumber { get; set; } = string.Empty;
        public string KvNumberLabel { get; set; } = string.Empty;
        public string ForeignHealthInsurance { get; set; } = string.Empty;
        public string ForeignHealthInsuranceLabel { get; set; } = string.Empty;
        public string RefugeeStatus { get; set; } = string.Empty;
        public string RefugeeStatusLabel { get; set; } = string.Empty;
        public int Height { get; set; }
        public string HeightLabel { get; set; }
        public int Weight { get; set; }
        public string WeightLabel { get; set; }
    }
}