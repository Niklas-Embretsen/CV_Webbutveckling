using CV_Webbutveckling.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CV_Webbutveckling.Models
{
    public class OnlineCVController : Controller
    {
        private readonly CV_WebbutvecklingContext _context;

        public OnlineCVController(CV_WebbutvecklingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OmMig()
        {
            return View();
        }

        public IActionResult ErfarenhetKunskaper()
        {
            return View();
        }

        public async Task<IActionResult> UtbildningKurser(string söktÄmne,
            string söktSkola, string söktKursnamn, string kurserDiv_IsCollapsed)
        #region Förklaring "kurserDiv_IsCollapsed
        //"kurserDiv_IsCollapsed" är en hjälpvariabel för att se till att div:en som
        //innehåller de kurser som jag gått
        //(div:en med id="Kurser_CollapseDiv" i "UtbildningKurser.cshtml")
        //inte är kollapsad när man först går in på viewen "UtbildningKurser.cshtml".
        //Däremot så vill jag att den ska förbli kollapsad efter att
        //man gjort en sökning bland kurserna så att man inte måste "återkollapsa"
        //den efter varje sökning.
        //"kurserDiv_IsCollapsed" är null när man först går in på "UtbildningKurser.cshtml",
        //men "input"-fältet som motsvarar "kurserDiv_IsCollapsed"
        //("<input id="kurserDiv_IsCollapsed_Input" type="hidden" asp-for="Collapsed" />")
        //sätts till "true" när man gått in i "UtbildningKurser.cshtml"
        //så att kurs-div:en förblir kollapsad efter varje sökning.
        #endregion
        {
            IQueryable<string> ämnesQuery = from k in _context.Kurs
                                            orderby k.Ämne
                                            select k.Ämne;

            IQueryable<string> skolQuery = from k in _context.Kurs
                                           orderby k.Skola
                                           select k.Skola;

            var kurser = from k in _context.Kurs
                         select k;

            if (!string.IsNullOrEmpty(söktKursnamn))
            {
                kurser = kurser.Where(k => k.Namn!.Contains(söktKursnamn));
            }

            if (!string.IsNullOrEmpty(söktSkola))
            {
                kurser = kurser.Where(k => k.Skola == söktSkola);
            }

            if (!string.IsNullOrEmpty(söktÄmne))
            {
                kurser = kurser.Where(k => k.Ämne == söktÄmne);
            }

            var kursSearchModel = new KursSearchModel
            {
                Ämnen = new SelectList(await ämnesQuery.Distinct().ToListAsync()),
                Skolor = new SelectList(await skolQuery.Distinct().ToListAsync()),
                Kurser = await kurser.ToListAsync(),
                KurserDiv_IsCollapsed = kurserDiv_IsCollapsed == null ? false : bool.Parse(kurserDiv_IsCollapsed)
            };

            return View(kursSearchModel);
        }
    }
}
