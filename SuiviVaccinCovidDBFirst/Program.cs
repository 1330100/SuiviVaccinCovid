using System;

namespace SuiviVaccinCovidDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Vaccin pfizer = new Vaccin { Nom = "Pfizer" };
            Vaccin moderna = new Vaccin { Nom = "Moderna" };

            Vaccin dose1Mylene = new Vaccin
            {
                Date = DateTime.Today,
                Nampatient = "LAPM12345678",
                Nom = "Moderna"
            };
            Vaccin dose1Gaston = new Vaccin
            {
                Date = new DateTime(2021, 01, 15),
                Nampatient = "BHEG12345678",
                Nom = "Pfizer"
            };
            VaccinBDContext context = new VaccinBDContext();
            context.Vaccins.Add(dose1Mylene);
            context.Vaccins.Add(dose1Gaston);
            context.SaveChanges();
            context.Remove(dose1Gaston);
            dose1Mylene.Nom = "Pfizer";
            context.SaveChanges();
            foreach (Vaccin vaccin in context.Vaccins)
                Console.WriteLine(vaccin);
        }
    }
}
