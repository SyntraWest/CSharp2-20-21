using System;


namespace TodoLijstLibrary
{
    public class TodoItem
    {
        public TodoItem()
        {
            Naam = "Nieuw TODO-item";
            TegenWanneer = DateTime.MaxValue;
            WanneerKlaar = null;
        }

        public string Naam { get; set; }

        /// <summary>
        /// Tegen wanneer moet dit klaar zijn
        /// </summary>
        public DateTime TegenWanneer { get; set; }

        /// <summary>
        /// Wanneer was dit klaar?
        /// </summary>
        public DateTime? WanneerKlaar { get; set; }

        /// <summary>
        /// Of dit item is afgewerkt.
        /// </summary>
        public bool IsKlaar => WanneerKlaar.HasValue;

        public void WerkNuAf() => WanneerKlaar = DateTime.Now;
    }
}
