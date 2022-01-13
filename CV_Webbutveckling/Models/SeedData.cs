using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CV_Webbutveckling.Data;
using System;
using System.Linq;

namespace CV_Webbutveckling.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CV_WebbutvecklingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CV_WebbutvecklingContext>>()))
            {
                // Kolla efter kurser.
                if (context.Kurs.Any())
                {
                    return; // DB har redan laddats med kurser.
                }

                context.Kurs.AddRange(
                    new Kurs
                    {
                        Namn = "Databaser med SQL",
                        Kurskod = "PGVSNV21",
                        Ämne = "Programmering",
                        Skola = "Teknikhögskolan Gävle",
                        Betyg = "VG",
                        Beskrivning = "Grundkurs i SQL",
                        Länk = "https://m8v2k9b5.stackpathcdn.com/wp-content/uploads" +
                            "/sites/4/2021/05/Kursplan-.net-utvecklare-g%C3%A4vle.pdf",
                        DatumKursAvslutad = new DateTime(2021, 4, 26),
                        Poäng = 35,
                        PoängTyp = "YH-poäng"
                    },

                    new Kurs
                    {
                        Namn = "Dataåtkomster i .NET",
                        Kurskod = "PGVSNV21",
                        Ämne = "Programmering",
                        Skola = "Teknikhögskolan Gävle",
                        Betyg = "VG",
                        Beskrivning = "Kurs i mestadels Entity Framework, " +
                            "\nmen också en del om asynkron programmering i C#.",
                        Länk = "https://m8v2k9b5.stackpathcdn.com/wp-content/uploads" +
                            "/sites/4/2021/05/Kursplan-.net-utvecklare-g%C3%A4vle.pdf",
                        DatumKursAvslutad = new DateTime(2022, 1, 12),
                        Poäng = 35,
                        PoängTyp = "YH-poäng"
                    },

                    new Kurs
                    {
                        Namn = "Grunder i Java-script",
                        Kurskod = "PGVSNV21",
                        Ämne = "Programmering",
                        Skola = "Teknikhögskolan Gävle",
                        Betyg = "VG",
                        Beskrivning = "Grundkurs i HTML/CSS/Javascript.",
                        Länk = "https://m8v2k9b5.stackpathcdn.com/wp-content/uploads/" +
                            "sites/4/2021/05/Kursplan-.net-utvecklare-g%C3%A4vle.pdf",
                        DatumKursAvslutad = new DateTime(2021, 10, 20),
                        Poäng = 15,
                        PoängTyp = "YH-poäng"
                    },

                    new Kurs
                    {
                        Namn = "Programmeringsteknik C#",
                        Kurskod = "PGVSNV21",
                        Ämne = "Programmering",
                        Skola = "Teknikhögskolan Gävle",
                        Betyg = "VG",
                        Beskrivning = "Grundkurs i C#",
                        Länk = "https://m8v2k9b5.stackpathcdn.com/wp-content/uploads/" +
                            "sites/4/2021/05/Kursplan-.net-utvecklare-g%C3%A4vle.pdf",
                        DatumKursAvslutad = new DateTime(2021, 3, 8),
                        Poäng = 55,
                        PoängTyp = "YH-poäng"
                    },

                    new Kurs
                    {
                        Namn = "Webbutveckling frontend",
                        Kurskod = "PGVSNV21",
                        Ämne = "Programmering",
                        Skola = "Teknikhögskolan Gävle",
                        Betyg = "VG",
                        Beskrivning = "Fortsättningskurs i HTML/CSS/Javascript efter kursen \n" +
                            "\"Grunder i Java-script - PGVSNV21\".",
                        Länk = "https://m8v2k9b5.stackpathcdn.com/wp-content/uploads" +
                            "/sites/4/2021/05/Kursplan-.net-utvecklare-g%C3%A4vle.pdf",
                        DatumKursAvslutad = new DateTime(2022, 1, 3),
                        Poäng = 30,
                        PoängTyp = "YH-poäng"
                    },

                    new Kurs
                    {
                        Namn = "Grundläggande Kemi",
                        Kurskod = "TFKE52",
                        Ämne = "Kemi",
                        Skola = "Linköpings Universitet",
                        Betyg = "5",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2013, 5, 30),
                        Poäng = 6,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Termodynamik och statistisk mekanik",
                        Kurskod = "TFKE52",
                        Ämne = "Fysik",
                        Skola = "Linköpings Universitet",
                        Betyg = "5",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2013, 5, 28),
                        Poäng = 6,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Modern fysik Y",
                        Kurskod = "TFYA11",
                        Ämne = "Fysik",
                        Skola = "Linköpings Universitet",
                        Betyg = "4",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2012, 12, 21),
                        Poäng = 6,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Optimeringslära fortsättningskurs",
                        Kurskod = "TAOP24",
                        Ämne = "Matematik",
                        Skola = "Linköpings Universitet",
                        Betyg = "5",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2012, 5, 29),
                        Poäng = 6,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Digitalteknik",
                        Kurskod = "TSEA51",
                        Ämne = "Digitalteknik",
                        Skola = "Linköpings Universitet",
                        Betyg = "G",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2012, 2, 28),
                        Poäng = 4,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Elkretsteori",
                        Kurskod = "E0003E",
                        Ämne = "Elektronik",
                        Skola = "Luleå Universitet",
                        Betyg = "5",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2007, 12, 18),
                        Poäng = 7.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Grundkurs i projekt- och industriell ekonomi",
                        Kurskod = "R0005N",
                        Ämne = "Ekonomi",
                        Skola = "Luleå Universitet",
                        Betyg = "5",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2007, 11, 6),
                        Poäng = 7.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Funktionsteori",
                        Kurskod = "M0017M",
                        Ämne = "Matematik",
                        Skola = "Luleå Universitet",
                        Betyg = "5",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2008, 6, 3),
                        Poäng = 7.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Mekanik II",
                        Kurskod = "M0017M",
                        Ämne = "Fysik",
                        Skola = "Luleå Universitet",
                        Betyg = "4",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2008, 5, 6),
                        Poäng = 7.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Introduktion till programmering",
                        Kurskod = "SMD180",
                        Ämne = "Programmering",
                        Skola = "Luleå Universitet",
                        Betyg = "5",
                        Beskrivning = "Grundkurs i Python",
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2006, 11, 20),
                        Poäng = 7.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Grundläggande algebra",
                        Kurskod = null,
                        Ämne = "Matematik",
                        Skola = "Uppsala Universitet",
                        Betyg = "5",
                        Beskrivning = "Grundkurs i algebra",
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2004, 10, 19),
                        Poäng = 4.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Fysik för poeter",
                        Kurskod = null,
                        Ämne = "Fysik",
                        Skola = "Uppsala Universitet",
                        Betyg = "G",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2005, 6, 7),
                        Poäng = 4.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Linjär Algebra",
                        Kurskod = null,
                        Ämne = "Matematik",
                        Skola = "Uppsala Universitet",
                        Betyg = "4",
                        Beskrivning = "Grundkurs i \"Linjär algebra\"",
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2005, 4, 7),
                        Poäng = 4.5,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Flerdimensionell analys",
                        Kurskod = null,
                        Ämne = "Matematik",
                        Skola = "Uppsala Universitet",
                        Betyg = "5",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2005, 6, 22),
                        Poäng = 9,
                        PoängTyp = "Hp"
                    },

                    new Kurs
                    {
                        Namn = "Företagsekonomi",
                        Kurskod = null,
                        Ämne = "Ekonomi",
                        Skola = "Uppsala Universitet",
                        Betyg = "3",
                        Beskrivning = null,
                        Länk = null,
                        DatumKursAvslutad = new DateTime(2006, 1, 14),
                        Poäng = 4.5,
                        PoängTyp = "Hp"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
