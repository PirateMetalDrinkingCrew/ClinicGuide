namespace WebAppTest.Models
{
    public class AnamnesisForm
    {
        public int Id { get; set; }
        public string Fever { get; set; } = string.Empty;
        public string Headache { get; set; } = string.Empty;
        public string Cold { get; set; } = string.Empty;
        public string Cough { get; set; } = string.Empty;
        public string NasalSinusPain { get; set; } = string.Empty;
        public string EyePain { get; set; } = string.Empty;
        public string BoneFracture { get; set; } = string.Empty;
        public string SoreThroat { get; set; } = string.Empty;
        public string AbdominalPain { get; set; } = string.Empty;
        public string LimbPain { get; set; } = string.Empty;
        public string ElbowPain { get; set; } = string.Empty;
        public string HighBloodPressure { get; set; } = string.Empty;
        public string HeartAttack { get; set; } = string.Empty;
        public string Stroke { get; set; } = string.Empty;
        public string ThyroidDisease { get; set; } = string.Empty;
        public string Diabetes { get; set; } = string.Empty;
        public virtual Language LanguageId { get; set; } = null!;
    }
}
