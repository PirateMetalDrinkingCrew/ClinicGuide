namespace WebAppTest.Models
{
    public class Anamnese
    {
        public int id { get; set; }
        public Sprache sprache_id { get; set; } = null!;
        public bool fever { get; set; }
        public bool headache { get; set; }
        public bool cold { get; set; }
        public bool cough { get; set; }
        public bool nasal_sinus_pain { get; set; }
        public bool eye_pain { get; set; }
        public bool bone_fracture { get; set; }
        public bool sore_throat { get; set; }
        public bool abdominal_pain { get; set; }
        public bool limb_pain { get; set; }
        public bool elbow_pain { get; set; }
        public bool high_blood_pressure { get; set; }
        public bool heart_attack { get; set; }
        public bool stroke { get; set; }
        public bool thyroid_disease { get; set; }
        public bool diabetes { get; set; }
    }
}
