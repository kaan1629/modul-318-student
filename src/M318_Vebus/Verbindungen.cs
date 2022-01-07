namespace M318_Vebus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Verbindungen
    {
        public Verbindungen(string? ankunftsZeit, string? abfahrtszeit, string zeit, string verspaetung)
        {
            this.AnkunftsZeit = ankunftsZeit;
            this.Abfahrtszeit = abfahrtszeit;
            this.Zeit = zeit;
            this.Verspaetung = verspaetung;
        }

        public string? AnkunftsZeit { get; set; }

        public string? Abfahrtszeit { get; set; }

        public string Zeit { get; set; }

        public string Verspaetung { get; set; }
    }
}
