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
            sprache deutsch = new sprache();
            deutsch.wert = "deutsch";
            Debug.WriteLine($"Sprache: {deutsch.Wert} angelegt");
            sprache franzoesisch = new sprache();
            franzoesisch.wert = "franzoesisch";
            Debug.WriteLine($"Sprache: {franzoesisch.Wert} angelegt");
            sprache italienisch = new sprache();
            italienisch.wert = "italienisch";
            Debug.WriteLine($"Sprache: {italienisch.Wert} angelegt");

            // Stammdaten
            // deutsch
            Stammdaten stammdaten_deutsch = new Stammdaten();
            stammdaten_deutsch.wert = 'deutsch';
            stammdaten_deutsch.surname = 'Name';
            stammdaten_deutsch.first_name = 'Vorname';
            stammdaten_deutsch.date_of_birth = 'Geburtstag';
            stammdaten_deutsch.street = 'Straße';
            stammdaten_deutsch.house_number = 'Hausnummer';
            stammdaten_deutsch.place_of_residence = 'Wohnort';
            stammdaten_deutsch.nationality = 'Staatsangehörigkeit';
            stammdaten_deutsch.gender = 'Geschlecht';
            stammdaten_deutsch.health_insurance = 'Krankenversichung';
            stammdaten_deutsch.kv_number = 'KV-Nummer';
            stammdaten_deutsch.foreign_health_insurance = 'ausländische Krankenversicherung';
            stammdaten_deutsch.refugee_status = 'Flüchtlingsstatus';
            stammdaten_deutsch.height = 'Größe';
            stammdaten_deutsch.weight = 'Gewicht';
            _database.Stammdaten.Add(stammdaten_deutsch);

            // franzoesisch
            Stammdaten stammdaten_franzoesisch = new Stammdaten();
            stammdaten_franzoesisch.wert = '';
            stammdaten_franzoesisch.surname = 'Nom';
            stammdaten_franzoesisch.first_name = 'Prénom';
            stammdaten_franzoesisch.date_of_birth = 'Date de naissance';
            stammdaten_franzoesisch.street = 'Rue';
            stammdaten_franzoesisch.house_number = 'Numéro de maison';
            stammdaten_franzoesisch.place_of_residence = 'Lieu de résidence';
            stammdaten_franzoesisch.nationality = 'Nationalité';
            stammdaten_franzoesisch.gender = 'Sexe';
            stammdaten_franzoesisch.health_insurance = 'Assurance maladie';
            stammdaten_franzoesisch.kv_number = 'Numéro dassurance maladie';
            stammdaten_franzoesisch.foreign_health_insurance = 'assurance maladie étrangère';
            stammdaten_franzoesisch.refugee_status = 'Statut de réfugié';
            stammdaten_franzoesisch.height = 'Taille';
            stammdaten_franzoesisch.weight = 'Poids';
            _database.Stammdaten.Add(stammdaten_franzoesisch);

            // italienisch
            Stammdaten stammdaten_italienisch = new Stammdaten();
            stammdaten_italienisch.wert = 'italienisch';
            stammdaten_italienisch.surname = 'Nom';
            stammdaten_italienisch.first_name = 'Prénom';
            stammdaten_italienisch.date_of_birth = 'Date de naissance';
            stammdaten_italienisch.street = 'Rue';
            stammdaten_italienisch.house_number = 'Numéro de maison';
            stammdaten_italienisch.place_of_residence = 'Lieu de résidence';
            stammdaten_italienisch.nationality = 'Nationalité';
            stammdaten_italienisch.gender = 'Sexe';
            stammdaten_italienisch.health_insurance = 'Assurance maladie';
            stammdaten_italienisch.kv_number = 'Numéro dassurance maladie';
            stammdaten_italienisch.foreign_health_insurance = 'assurance maladie étrangère';
            stammdaten_italienisch.refugee_status = 'Statut de réfugié';
            stammdaten_italienisch.height = 'Taille ';
            stammdaten_italienisch.weight = 'Poids';
            _database.Stammdaten.Add(stammdaten_italienisch);

            // Anamnese
            // deutsch
            Anamnese anamnese_deutsch = new Anamnese();
            anamnese_deutsch.wert = 'deutsch';
            anamnese_deutsch.fever = 'Fieber';
            anamnese_deutsch.headache = 'Kopfschmerzen';
            anamnese_deutsch.cold = 'Schnupfen';
            anamnese_deutsch.cough = 'Husten';
            anamnese_deutsch.nasal_sinus_pain = 'Nasen-Nebenhöhlen-Schmerzen';
            anamnese_deutsch.eye_pain = 'Augenschmerzen';
            anamnese_deutsch.bone_fracture = 'Knochenbruch';
            anamnese_deutsch.sore_throat = 'Halsschmerzen';
            anamnese_deutsch.abdominal_pain = 'Bauchschmerzen ';
            anamnese_deutsch.limb_pain = 'Gliederschmerzen';
            anamnese_deutsch.elbow_pain = 'Ellenbogen';
            anamnese_deutsch.high_blood_pressure = 'Hoher Blutdruck';
            anamnese_deutsch.heart_attack = 'Herzinfarkt';
            anamnese_deutsch.stroke = 'Schlaganfall';
            anamnese_deutsch.thyroid_disease = 'Schilddrüsenkrankheit';
            anamnese_deutsch.diabetes = 'Diabetes';
            _database.Anamnese.Add(anamnese_deutsch);

            // franzoesisch
            Anamnese anamnese_franzoesisch = new Anamnese();
            anamnese_franzoesisch.wert = 'franzoesisch';
            anamnese_franzoesisch.fever = 'Fièvre';
            anamnese_franzoesisch.headache = 'Maux de tête';
            anamnese_franzoesisch.cold = 'Rhume';
            anamnese_franzoesisch.cough = 'Toux';
            anamnese_franzoesisch.nasal_sinus_pain = 'Douleurs nasales et sinusales';
            anamnese_franzoesisch.eye_pain = 'Douleurs oculaires';
            anamnese_franzoesisch.bone_fracture = 'Fracture des os';
            anamnese_franzoesisch.sore_throat = 'Maux de gorge';
            anamnese_franzoesisch.abdominal_pain = 'Douleurs abdominales ';
            anamnese_franzoesisch.limb_pain = 'Douleurs dans les membres';
            anamnese_franzoesisch.elbow_pain = 'Coude';
            anamnese_franzoesisch.high_blood_pressure = 'Hypertension artérielle';
            anamnese_franzoesisch.heart_attack = 'Infarctus du myocarde';
            anamnese_franzoesisch.stroke = 'Accident vasculaire cérébral';
            anamnese_franzoesisch.thyroid_disease = 'Maladie de la thyroïde';
            anamnese_franzoesisch.diabetes = 'Diabète';
            _database.Anamnese.Add(anamnese_franzoesisch);

            // italienisch
            Anamnese anamnese_italienisch = new Anamnese();
            anamnese_italienisch.wert = 'italienisch';
            anamnese_italienisch.fever = 'febbre';
            anamnese_italienisch.headache = 'Mal di testa';
            anamnese_italienisch.cold = 'Raffreddore';
            anamnese_italienisch.cough = 'Tosse';
            anamnese_italienisch.nasal_sinus_pain = 'Dolore ai seni nasali';
            anamnese_italienisch.eye_pain = 'Dolore agli occhi';
            anamnese_italienisch.bone_fracture = 'Frattura ossea';
            anamnese_italienisch.sore_throat = 'Mal di gola';
            anamnese_italienisch.abdominal_pain = 'Dolore addominale ';
            anamnese_italienisch.limb_pain = 'Dolore agli arti';
            anamnese_italienisch.elbow_pain = 'Dolore al gomito';
            anamnese_italienisch.high_blood_pressure = 'Alta pressione sanguigna';
            anamnese_italienisch.heart_attack = 'Attacco di cuore';
            anamnese_italienisch.stroke = 'Ictus';
            anamnese_italienisch.thyroid_disease = 'Malattie della tiroide';
            anamnese_italienisch.diabetes = 'Diabete';
            _database.Anamnese.Add(anamnese_italienisch);


            _database.SaveChanges();
        }
    }
}
