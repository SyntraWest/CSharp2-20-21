using System;
using System.Collections.Generic;

namespace Rosetta.Interface
{
    /// <summary>
    /// Een tabel waarin termen (<see cref="ITerm"/>) in verschillende talen (<see cref="ITaal"/>) naast elkaar kunnen gezet worden.
    /// </summary>
    public interface IRosettaTabel : IEnumerable<ITermCombinatie>
    {
        /// <summary>
        /// De indexer geeft de <see cref="ITermCombinatie"/> op de gegeven positie
        /// </summary>
        /// <param name="index">Positie van de gevraagde termcombinatie</param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"/>
        ITermCombinatie this[int index] { get; }

        /// <summary>
        /// Alle talen die aan de <see cref="IRosettaTabel"/> zijn toegevoegd
        /// </summary>
        IReadOnlyList<ITaal> Talen { get; }

        /// <summary>
        /// Voegt een taal toe aan de <see cref="IRosettaTabel"/>. Talen moeten toegevoegd worden voordat er termen worden toegevoegd.
        /// </summary>
        /// <param name="taal">Naam van de taal om toe te voegen</param>
        /// <returns>De toegevoegde taal</returns>
        ITaal VoegTaalToe(string taal);

        /// <summary>
        /// Wisselt 2 talen van plaats in de <see cref="IRosettaTabel"/>
        /// <para>
        /// <see cref="ArgumentOutOfRangeException"/> als <paramref name="index1"/> of <paramref name="index2"/> kleiner is dan 0 of groter dan of gelijk aan het aantal talen
        /// </para><para>
        /// <see cref="ArgumentException"/> als <paramref name="index1"/> == <paramref name="index2"/>
        /// </para>
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <exception cref="ArgumentOutOfRangeException">als <paramref name="index1"/> of <paramref name="index2"/> kleiner is dan 0 of groter dan of gelijk aan het aantal talen</exception>
        /// <exception cref="ArgumentException">als <paramref name="index1"/> == <paramref name="index2"/></exception>
        void WisselTalen(int index1, int index2);

        /// <summary>
        /// Wisselt 2 termen van plaats in de <see cref="IRosettaTabel"/> voor alle talen
        /// <para>
        /// <see cref="ArgumentOutOfRangeException"/> als <paramref name="index1"/> of <paramref name="index2"/> kleiner is dan 0 of groter dan of gelijk aan het aantal talen
        /// </para><para>
        /// <see cref="ArgumentException"/> als <paramref name="index1"/> == <paramref name="index2"/>
        /// </para>
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <exception cref="ArgumentOutOfRangeException"/>
        /// <exception cref="ArgumentException"/>
        void WisselTermen(int index1, int index2);

        /// <summary>
        /// Maakt een kopie van deze <see cref="IRosettaTabel"/>, maar zonder de gegeven <paramref name="taal"/>
        /// </summary>
        /// <param name="taal"></param>
        /// <returns>Een nieuwe <see cref="IRosettaTabel"/></returns>
        /// <exception cref="ArgumentException"/>
        /// <exception cref="ArgumentNullException"/>
        IRosettaTabel ZonderTaal(ITaal taal);

        /// <summary>
        /// Maakt een kopie van deze <see cref="IRosettaTabel"/>, maar zonder de gegeven <paramref name="taal"/>
        /// </summary>
        /// <param name="taal"></param>
        /// <returns>Een nieuwe <see cref="IRosettaTabel"/></returns>
        /// <exception cref="ArgumentException"/>
        IRosettaTabel ZonderTaal(int taal);

        /// <summary>
        /// Selecteert een aantal van de <see cref="ITermCombinatie"/>s in deze <see cref="IRosettaTabel"/> en maakt daar een nieuwe <see cref="IRosettaTabel"/> van met dezelfde talen.
        /// </summary>
        /// <param name="combinaties"></param>
        /// <returns></returns>
        IRosettaTabel MetEnkelDezeTermcombinaties(params int[] combinaties);

        IRosettaTabel MetWillekeurigeCombinaties(int aantal);

        /// <summary>
        /// Sorteert de <see cref="ITermCombinatie"/>s in een willekeurige volgorde.
        /// </summary>
        void SchudDoorElkaar();

        /// <summary>
        /// Sorteert de termcombinaties zodat ze voor de gegeven taal oplopend of aflopend alfabetisch gesorteerd zijn.
        /// </summary>
        /// <param name="taal">De taal waarvan de <see cref="ITerm"/>en gesorteerd worden.</param>
        /// <param name="oplopend"><code>true</code>om oplopend, <code>false</code> om aflopend te sorteren</param>
        void SorteerOpTaal(ITaal taal, bool oplopend);

        /// <summary>
        /// Sorteert de termcombinaties zodat ze voor de gegeven taal oplopend alfabetisch gesorteerd zijn.
        /// </summary>
        /// <param name="taal">De taal waarvan de <see cref="ITerm"/>en gesorteerd worden.</param>
        void SorteerOpTaal(ITaal taal);
    }
}
