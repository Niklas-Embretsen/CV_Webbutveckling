using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CV_Webbutveckling.Models
{
    public class KursSearchModel
    {
        public List<Kurs>? Kurser { get; set; }
        public SelectList? Ämnen { get; set; }
        public SelectList? Skolor { get; set; }
        public string? SöktKursnamn { get; set; }
        public string? SöktÄmne { get; set; }
        public string? SöktSkola { get; set; }
        public bool? KurserDiv_IsCollapsed { get; set; }
    }
}
