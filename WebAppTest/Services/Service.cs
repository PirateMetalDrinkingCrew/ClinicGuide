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
            Language german = new Language();
            german.Value = "german";
            Debug.WriteLine($"Sprache: {german.Value} angelegt");
            Language french = new Language();
            french.Value = "french";
            Debug.WriteLine($"Sprache: {french.Value} angelegt");
            Language italian = new Language();
            italian.Value = "italian";
            Debug.WriteLine($"Sprache: {italian.Value} angelegt");

            // Stammdaten
            // german
            MasterDataForm masterDataGerman = new MasterDataForm();
            masterDataGerman.LanguageId = german;
            masterDataGerman.Surname = "Name";
            masterDataGerman.FirstName = "Vorname";
            masterDataGerman.DateOfBirth = "Geburtstag";
            masterDataGerman.Street = "Straße";
            masterDataGerman.HouseNumber = "Hausnummer";
            masterDataGerman.PlaceOfResidence = "Wohnort";
            masterDataGerman.Nationality = "Staatsangehörigkeit";
            masterDataGerman.Gender = "Geschlecht";
            masterDataGerman.HealthInsurance = "Krankenversichung";
            masterDataGerman.KvNumber = "KV-Nummer";
            masterDataGerman.ForeignHealthInsurance = "ausländische Krankenversicherung";
            masterDataGerman.RefugeeStatus = "Flüchtlingsstatus";
            masterDataGerman.Height = "Größe";
            masterDataGerman.Weight = "Gewicht";
            _database.MasterDataForm.Add(masterDataGerman);

            // french
            MasterDataForm masterDataFrench = new MasterDataForm();
            masterDataFrench.LanguageId = french;
            masterDataFrench.Surname = "Nom";
            masterDataFrench.FirstName = "Prénom";
            masterDataFrench.DateOfBirth = "Date de naissance";
            masterDataFrench.Street = "Rue";
            masterDataFrench.HouseNumber = "Numéro de maison";
            masterDataFrench.PlaceOfResidence = "Lieu de résidence";
            masterDataFrench.Nationality = "Nationalité";
            masterDataFrench.Gender = "Sexe";
            masterDataFrench.HealthInsurance = "Assurance maladie";
            masterDataFrench.KvNumber = "Numéro dassurance maladie";
            masterDataFrench.ForeignHealthInsurance = "assurance maladie étrangère";
            masterDataFrench.RefugeeStatus = "Statut de réfugié";
            masterDataFrench.Height = "Taille";
            masterDataFrench.Weight = "Poids";
            _database.MasterDataForm.Add(masterDataFrench);

            // italian
            MasterDataForm masterDataItalian = new MasterDataForm();
            masterDataItalian.LanguageId = italian;
            masterDataItalian.Surname = "Nom";
            masterDataItalian.FirstName = "Prénom";
            masterDataItalian.DateOfBirth = "Date de naissance";
            masterDataItalian.Street = "Rue";
            masterDataItalian.HouseNumber = "Numéro de maison";
            masterDataItalian.PlaceOfResidence = "Lieu de résidence";
            masterDataItalian.Nationality = "Nationalité";
            masterDataItalian.Gender = "Sexe";
            masterDataItalian.HealthInsurance = "Assurance maladie";
            masterDataItalian.KvNumber = "Numéro dassurance maladie";
            masterDataItalian.ForeignHealthInsurance = "assurance maladie étrangère";
            masterDataItalian.RefugeeStatus = "Statut de réfugié";
            masterDataItalian.Height = "Taille ";
            masterDataItalian.Weight = "Poids";
            _database.MasterDataForm.Add(masterDataItalian);

            // Anamnese
            // german
            AnamnesisForm anamnesisGerman = new AnamnesisForm();
            anamnesisGerman.LanguageId = german;
            anamnesisGerman.Fever = "Fieber";
            anamnesisGerman.Headache = "Kopfschmerzen";
            anamnesisGerman.Cold = "Schnupfen";
            anamnesisGerman.Cough = "Husten";
            anamnesisGerman.NasalSinusPain = "Nasen-Nebenhöhlen-Schmerzen";
            anamnesisGerman.EyePain = "Augenschmerzen";
            anamnesisGerman.BoneFracture = "Knochenbruch";
            anamnesisGerman.SoreThroat = "Halsschmerzen";
            anamnesisGerman.AbdominalPain = "Bauchschmerzen ";
            anamnesisGerman.LimbPain = "Gliederschmerzen";
            anamnesisGerman.ElbowPain = "Ellenbogen";
            anamnesisGerman.HighBloodPressure = "Hoher Blutdruck";
            anamnesisGerman.HeartAttack = "Herzinfarkt";
            anamnesisGerman.Stroke = "Schlaganfall";
            anamnesisGerman.ThyroidDisease = "Schilddrüsenkrankheit";
            anamnesisGerman.Diabetes = "Diabetes";
            _database.AnamnesisForm.Add(anamnesisGerman);

            // french
            AnamnesisForm anamnesisFrench = new AnamnesisForm();
            anamnesisFrench.LanguageId = french;
            anamnesisFrench.Fever = "Fièvre";
            anamnesisFrench.Headache = "Maux de tête";
            anamnesisFrench.Cold = "Rhume";
            anamnesisFrench.Cough = "Toux";
            anamnesisFrench.NasalSinusPain = "Douleurs nasales et sinusales";
            anamnesisFrench.EyePain = "Douleurs oculaires";
            anamnesisFrench.BoneFracture = "Fracture des os";
            anamnesisFrench.SoreThroat = "Maux de gorge";
            anamnesisFrench.AbdominalPain = "Douleurs abdominales ";
            anamnesisFrench.LimbPain = "Douleurs dans les membres";
            anamnesisFrench.ElbowPain = "Coude";
            anamnesisFrench.HighBloodPressure = "Hypertension artérielle";
            anamnesisFrench.HeartAttack = "Infarctus du myocarde";
            anamnesisFrench.Stroke = "Accident vasculaire cérébral";
            anamnesisFrench.ThyroidDisease = "Maladie de la thyroïde";
            anamnesisFrench.Diabetes = "Diabète";
            _database.AnamnesisForm.Add(anamnesisFrench);

            // italian
            AnamnesisForm anamnesisItalian = new AnamnesisForm();
            anamnesisItalian.LanguageId = italian;
            anamnesisItalian.Fever = "febbre";
            anamnesisItalian.Headache = "Mal di testa";
            anamnesisItalian.Cold = "Raffreddore";
            anamnesisItalian.Cough = "Tosse";
            anamnesisItalian.NasalSinusPain = "Dolore ai seni nasali";
            anamnesisItalian.EyePain = "Dolore agli occhi";
            anamnesisItalian.BoneFracture = "Frattura ossea";
            anamnesisItalian.SoreThroat = "Mal di gola";
            anamnesisItalian.AbdominalPain = "Dolore addominale ";
            anamnesisItalian.LimbPain = "Dolore agli arti";
            anamnesisItalian.ElbowPain = "Dolore al gomito";
            anamnesisItalian.HighBloodPressure = "Alta pressione sanguigna";
            anamnesisItalian.HeartAttack = "Attacco di cuore";
            anamnesisItalian.Stroke = "Ictus";
            anamnesisItalian.ThyroidDisease = "Malattie della tiroide";
            anamnesisItalian.Diabetes = "Diabete";
            _database.AnamnesisForm.Add(anamnesisItalian);


            await _database.SaveChangesAsync();
        }
    }
}
