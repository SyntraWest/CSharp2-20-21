namespace Rosetta.Interface
{
    /// <summary>
    /// Een taal in een <see cref="IRosettaTabel"/>
    /// </summary>
    public interface ITaal
    {
        /// <summary>
        /// Volgnummer van de taal in de <see cref="IRosettaTabel"/>
        /// </summary>
        int Index { get; }

        /// <summary>
        /// Naam van de taal
        /// </summary>
        string Taal { get; }

        /// <summary>
        /// Bepaal de kortste lengte van termen in deze taal
        /// </summary>
        /// <returns></returns>
        int MinimumTermLengte();

        /// <summary>
        /// Bepaal de grootste lengte van termen in deze taal
        /// </summary>
        /// <returns></returns>
        int MaximumTermLengte();

        /// <summary>
        /// Bepaal het aantal termen in deze taal
        /// </summary>
        int AantalTermen { get; }

    }
}
