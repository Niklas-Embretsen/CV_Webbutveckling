using System.ComponentModel.DataAnnotations;

namespace CV_Webbutveckling.Models
{
    public class Kurs
    {
        public int Id { get; set; }
        public string Namn { get; set; }
        public string? Kurskod { get; set; }
        public string Ämne { get; set; }
        public string Skola { get; set; }
        public string Betyg { get; set; }
        public string? Beskrivning { get; set; }
        public string? Länk { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatumKursAvslutad { get; set; }
        public double Poäng { get; set; }
        public string PoängTyp { get; set; }

    }
}
