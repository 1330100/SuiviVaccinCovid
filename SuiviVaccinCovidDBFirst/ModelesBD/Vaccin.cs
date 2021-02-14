using System;
using System.Collections.Generic;

#nullable disable

namespace SuiviVaccinCovidDBFirst
{
    public partial class Vaccin
    {
        public int VaccinId { get; set; }
        public DateTime Date { get; set; }
        public string Nom { get; set; }
        public string Nampatient { get; set; }

        public override string ToString()
        {
            return $" Vaccin #{VaccinId}({Nom}), adiminstré le {Date}à {Nampatient}";
        }
    }
}
