using System.ComponentModel.DataAnnotations;

namespace Event_Planner.Models
{
    public class Locatie
    {
        public int ID { get; set; }

        [Display(Name = "Denumirea locatiei")]
        public string Denumire { get; set; }
        public string Adresa { get; set; }

        [Display(Name = "Imagine")]
        public string Poza { get; set; }

        [Display(Name = "Capacitate maxima")]
        public int Nr_pers { get; set; }

        [Display(Name = "Pret/zi (RON)")]
        public decimal Pret { get; set; }

        public string Descriere { get; set; }

        [Display(Name = "Din data de: ")]
        [DataType(DataType.Date)]
        public DateTime DataInceput { get; set; }

        [Display(Name = "Pana la data de: ")]

        [DataType(DataType.Date)]
        public DateTime DataSfarsit { get; set; }
    }
}
