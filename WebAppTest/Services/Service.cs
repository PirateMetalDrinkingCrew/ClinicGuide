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
            _database.Database.EnsureCreated();
            FillDatabase();
        }
        private void FillDatabase()
        {
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
            MasterData stammdaten_deutsch = new MasterData();
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
            MasterData stammdaten_franzoesisch = new MasterData();
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
            MasterData stammdaten_italienisch = new MasterData();
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
            Anamnese anamnese_deutsch = new Anamnese();
            anamnese_deutsch.LanguageId = deutsch;
            anamnese_deutsch.fever = "Fieber";
            anamnese_deutsch.headache = "Kopfschmerzen";
            anamnese_deutsch.cold = "Schnupfen";
            anamnese_deutsch.cough = "Husten";
            anamnese_deutsch.nasal_sinus_pain = "Nasen-Nebenhöhlen-Schmerzen";
            anamnese_deutsch.eye_pain = "Augenschmerzen";
            anamnese_deutsch.bone_fracture = "Knochenbruch";
            anamnese_deutsch.sore_throat = "Halsschmerzen";
            anamnese_deutsch.abdominal_pain = "Bauchschmerzen ";
            anamnese_deutsch.limb_pain = "Gliederschmerzen";
            anamnese_deutsch.elbow_pain = "Ellenbogen";
            anamnese_deutsch.high_blood_pressure = "Hoher Blutdruck";
            anamnese_deutsch.heart_attack = "Herzinfarkt";
            anamnese_deutsch.stroke = "Schlaganfall";
            anamnese_deutsch.thyroid_disease = "Schilddrüsenkrankheit";
            anamnese_deutsch.diabetes = "Diabetes";
            _database.Anamnese.Add(anamnese_deutsch);

            // franzoesisch
            Anamnese anamnese_franzoesisch = new Anamnese();
            anamnese_franzoesisch.LanguageId = franzoesisch;
            anamnese_franzoesisch.fever = "Fièvre";
            anamnese_franzoesisch.headache = "Maux de tête";
            anamnese_franzoesisch.cold = "Rhume";
            anamnese_franzoesisch.cough = "Toux";
            anamnese_franzoesisch.nasal_sinus_pain = "Douleurs nasales et sinusales";
            anamnese_franzoesisch.eye_pain = "Douleurs oculaires";
            anamnese_franzoesisch.bone_fracture = "Fracture des os";
            anamnese_franzoesisch.sore_throat = "Maux de gorge";
            anamnese_franzoesisch.abdominal_pain = "Douleurs abdominales ";
            anamnese_franzoesisch.limb_pain = "Douleurs dans les membres";
            anamnese_franzoesisch.elbow_pain = "Coude";
            anamnese_franzoesisch.high_blood_pressure = "Hypertension artérielle";
            anamnese_franzoesisch.heart_attack = "Infarctus du myocarde";
            anamnese_franzoesisch.stroke = "Accident vasculaire cérébral";
            anamnese_franzoesisch.thyroid_disease = "Maladie de la thyroïde";
            anamnese_franzoesisch.diabetes = "Diabète";
            _database.Anamnese.Add(anamnese_franzoesisch);

            // italienisch
            Anamnese anamnese_italienisch = new Anamnese();
            anamnese_italienisch.LanguageId = italienisch;
            anamnese_italienisch.fever = "febbre";
            anamnese_italienisch.headache = "Mal di testa";
            anamnese_italienisch.cold = "Raffreddore";
            anamnese_italienisch.cough = "Tosse";
            anamnese_italienisch.nasal_sinus_pain = "Dolore ai seni nasali";
            anamnese_italienisch.eye_pain = "Dolore agli occhi";
            anamnese_italienisch.bone_fracture = "Frattura ossea";
            anamnese_italienisch.sore_throat = "Mal di gola";
            anamnese_italienisch.abdominal_pain = "Dolore addominale ";
            anamnese_italienisch.limb_pain = "Dolore agli arti";
            anamnese_italienisch.elbow_pain = "Dolore al gomito";
            anamnese_italienisch.high_blood_pressure = "Alta pressione sanguigna";
            anamnese_italienisch.heart_attack = "Attacco di cuore";
            anamnese_italienisch.stroke = "Ictus";
            anamnese_italienisch.thyroid_disease = "Malattie della tiroide";
            anamnese_italienisch.diabetes = "Diabete";
            _database.Anamnese.Add(anamnese_italienisch);


            _database.SaveChanges();
        }
    }
}
