using System.Diagnostics;
using WebAppTest.Models;

namespace WebAppTest.Services
{
    public class Service
    {
        private readonly Context _database;

        public Service()
        {
            _database = new Context();
        }
        public async Task FillDatabase()
        {
            var created = await _database.Database.EnsureCreatedAsync();
            Console.WriteLine($"Created: {created}");
            // Sprache
            Language deutsch = new Language();
            deutsch.Value = "deutsch";
            Debug.WriteLine($"Sprache: {deutsch.Value} angelegt");
            Language franzoesisch = new Language();
            franzoesisch.Value = "franzoesisch";
            Debug.WriteLine($"Sprache: {franzoesisch.Value} angelegt");
            Language italienisch = new Language();
            italienisch.Value = "italienisch";
            Debug.WriteLine($"Sprache: {italienisch.Value} angelegt");

            // Stammdaten
            // deutsch
            MasterDataForm stammdaten_deutsch = new MasterDataForm();
            stammdaten_deutsch.LanguageId = deutsch;
            stammdaten_deutsch.Surname = "Name";
            stammdaten_deutsch.FirstName = "Vorname";
            stammdaten_deutsch.DateOfBirth = "Geburtstag";
            stammdaten_deutsch.Street = "Straße";
            stammdaten_deutsch.HouseNumber = "Hausnummer";
            stammdaten_deutsch.PlaceOfResidence = "Wohnort";
            stammdaten_deutsch.Nationality = "Staatsangehörigkeit";
            stammdaten_deutsch.Gender = "Geschlecht";
            stammdaten_deutsch.HealthInsurance = "Krankenversichung";
            stammdaten_deutsch.KvNumber = "KV-Nummer";
            stammdaten_deutsch.ForeignHealthInsurance = "ausländische Krankenversicherung";
            stammdaten_deutsch.RefugeeStatus = "Flüchtlingsstatus";
            stammdaten_deutsch.Height = "Größe";
            stammdaten_deutsch.Weight = "Gewicht";
            _database.Stammdaten.Add(stammdaten_deutsch);

            // franzoesisch
            MasterDataForm stammdaten_franzoesisch = new MasterDataForm();
            stammdaten_franzoesisch.LanguageId = franzoesisch;
            stammdaten_franzoesisch.Surname = "Nom";
            stammdaten_franzoesisch.FirstName = "Prénom";
            stammdaten_franzoesisch.DateOfBirth = "Date de naissance";
            stammdaten_franzoesisch.Street = "Rue";
            stammdaten_franzoesisch.HouseNumber = "Numéro de maison";
            stammdaten_franzoesisch.PlaceOfResidence = "Lieu de résidence";
            stammdaten_franzoesisch.Nationality = "Nationalité";
            stammdaten_franzoesisch.Gender = "Sexe";
            stammdaten_franzoesisch.HealthInsurance = "Assurance maladie";
            stammdaten_franzoesisch.KvNumber = "Numéro dassurance maladie";
            stammdaten_franzoesisch.ForeignHealthInsurance = "assurance maladie étrangère";
            stammdaten_franzoesisch.RefugeeStatus = "Statut de réfugié";
            stammdaten_franzoesisch.Height = "Taille";
            stammdaten_franzoesisch.Weight = "Poids";
            _database.Stammdaten.Add(stammdaten_franzoesisch);

            // italienisch
            MasterDataForm stammdaten_italienisch = new MasterDataForm();
            stammdaten_italienisch.LanguageId = italienisch;
            stammdaten_italienisch.Surname = "Nom";
            stammdaten_italienisch.FirstName = "Prénom";
            stammdaten_italienisch.DateOfBirth = "Date de naissance";
            stammdaten_italienisch.Street = "Rue";
            stammdaten_italienisch.HouseNumber = "Numéro de maison";
            stammdaten_italienisch.PlaceOfResidence = "Lieu de résidence";
            stammdaten_italienisch.Nationality = "Nationalité";
            stammdaten_italienisch.Gender = "Sexe";
            stammdaten_italienisch.HealthInsurance = "Assurance maladie";
            stammdaten_italienisch.KvNumber = "Numéro dassurance maladie";
            stammdaten_italienisch.ForeignHealthInsurance = "assurance maladie étrangère";
            stammdaten_italienisch.RefugeeStatus = "Statut de réfugié";
            stammdaten_italienisch.Height = "Taille ";
            stammdaten_italienisch.Weight = "Poids";
            _database.Stammdaten.Add(stammdaten_italienisch);

            // Anamnese
            // deutsch
            AnamnesisForm anamnese_deutsch = new AnamnesisForm();
            anamnese_deutsch.LanguageId = deutsch;
            anamnese_deutsch.Fever = "Fieber";
            anamnese_deutsch.Headache = "Kopfschmerzen";
            anamnese_deutsch.Cold = "Schnupfen";
            anamnese_deutsch.Cough = "Husten";
            anamnese_deutsch.NasalSinusPain = "Nasen-Nebenhöhlen-Schmerzen";
            anamnese_deutsch.EyePain = "Augenschmerzen";
            anamnese_deutsch.BoneFracture = "Knochenbruch";
            anamnese_deutsch.SoreThroat = "Halsschmerzen";
            anamnese_deutsch.AbdominalPain = "Bauchschmerzen ";
            anamnese_deutsch.LimbPain = "Gliederschmerzen";
            anamnese_deutsch.ElbowPain = "Ellenbogen";
            anamnese_deutsch.HighBloodPressure = "Hoher Blutdruck";
            anamnese_deutsch.HeartAttack = "Herzinfarkt";
            anamnese_deutsch.Stroke = "Schlaganfall";
            anamnese_deutsch.ThyroidDisease = "Schilddrüsenkrankheit";
            anamnese_deutsch.Diabetes = "Diabetes";
            _database.Anamnese.Add(anamnese_deutsch);

            // franzoesisch
            AnamnesisForm anamnese_franzoesisch = new AnamnesisForm();
            anamnese_franzoesisch.LanguageId = franzoesisch;
            anamnese_franzoesisch.Fever = "Fièvre";
            anamnese_franzoesisch.Headache = "Maux de tête";
            anamnese_franzoesisch.Cold = "Rhume";
            anamnese_franzoesisch.Cough = "Toux";
            anamnese_franzoesisch.NasalSinusPain = "Douleurs nasales et sinusales";
            anamnese_franzoesisch.EyePain = "Douleurs oculaires";
            anamnese_franzoesisch.BoneFracture = "Fracture des os";
            anamnese_franzoesisch.SoreThroat = "Maux de gorge";
            anamnese_franzoesisch.AbdominalPain = "Douleurs abdominales ";
            anamnese_franzoesisch.LimbPain = "Douleurs dans les membres";
            anamnese_franzoesisch.ElbowPain = "Coude";
            anamnese_franzoesisch.HighBloodPressure = "Hypertension artérielle";
            anamnese_franzoesisch.HeartAttack = "Infarctus du myocarde";
            anamnese_franzoesisch.Stroke = "Accident vasculaire cérébral";
            anamnese_franzoesisch.ThyroidDisease = "Maladie de la thyroïde";
            anamnese_franzoesisch.Diabetes = "Diabète";
            _database.Anamnese.Add(anamnese_franzoesisch);

            // italienisch
            AnamnesisForm anamnese_italienisch = new AnamnesisForm();
            anamnese_italienisch.LanguageId = italienisch;
            anamnese_italienisch.Fever = "febbre";
            anamnese_italienisch.Headache = "Mal di testa";
            anamnese_italienisch.Cold = "Raffreddore";
            anamnese_italienisch.Cough = "Tosse";
            anamnese_italienisch.NasalSinusPain = "Dolore ai seni nasali";
            anamnese_italienisch.EyePain = "Dolore agli occhi";
            anamnese_italienisch.BoneFracture = "Frattura ossea";
            anamnese_italienisch.SoreThroat = "Mal di gola";
            anamnese_italienisch.AbdominalPain = "Dolore addominale ";
            anamnese_italienisch.LimbPain = "Dolore agli arti";
            anamnese_italienisch.ElbowPain = "Dolore al gomito";
            anamnese_italienisch.HighBloodPressure = "Alta pressione sanguigna";
            anamnese_italienisch.HeartAttack = "Attacco di cuore";
            anamnese_italienisch.Stroke = "Ictus";
            anamnese_italienisch.ThyroidDisease = "Malattie della tiroide";
            anamnese_italienisch.Diabetes = "Diabete";
            _database.Anamnese.Add(anamnese_italienisch);


            await _database.SaveChangesAsync();
        }
    }
}
