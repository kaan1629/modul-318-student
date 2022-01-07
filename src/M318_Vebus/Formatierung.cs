namespace M318_Vebus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Formatierung
    {
        public string DatumEntfernen(DateTime? DatumZeit)
        {
            DateTime dateTime;
            try
            {
                if (DatumZeit.HasValue)
                {
                    dateTime = DatumZeit.Value;

                    string Zeit = dateTime.ToString();
                    Zeit = Zeit.Remove(0, 10);
                    Zeit = Zeit.Remove(5, 3);
                    return Zeit;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Ein Fehler ist beim bei der Ausgabe passiert", "Error - Ausgabefehler");
                return string.Empty;
            }
        }

        public string ZeitEntfernen(string ZeitEingabe)
        {
            string Zeit = ZeitEingabe;
            Zeit = Zeit.Remove(0, 3);
            Zeit = Zeit.Remove(5, 3);
            return Zeit;
        }

        public string VerspaetungCheck(int? Delay)
        {
            if (Delay.HasValue)
            {
                return $"{Delay}min";
            }
            else
            {

                return $"0min";
            }
        }
    }
}
