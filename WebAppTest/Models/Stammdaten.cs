using System;

namespace WebAppTest.Models
{
    public class Stammdaten
    {
        public int id { get; set; }
        public Sprache sprache_id { get; set; } = null!;
        public string surname { get; set; }
        public string first_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string street { get; set; }
        public string house_number { get; set; } // String wegen möglichen Buchstaben in Hausnummer
        public string place_of_residence { get; set; }
        public string nationality { get; set; }
        public string gender { get; set; }
        public string health_insurance { get; set; }
        public string kv_number { get; set; }
        public string foreign_health_insurance { get; set; }
        public string refugee_status { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
    }
}
