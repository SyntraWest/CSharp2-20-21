using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RosettaInterface
{
    public interface IRosettaTabel : IEnumerable<ITermCombinatie>
    {
        /// <summary>
        /// De indexer geeft een
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
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
    }

    /// <summary>
    /// Een combinatie van termen in verschillende talen.
    /// </summary>
    public interface ITermCombinatie
    {
        /// <summary>
        /// Volgnummer van de termcombinatie in de <see cref="IRosettaTabel"/>
        /// </summary>
        int Index { get; }

        /// <summary>
        /// Geeft een term in 1 taal
        /// </summary>
        /// <param name="index">index van de taal in de <see cref="IRosettaTabel"/> waaruit deze combinatie komt</param>
        /// <returns>1 term uit de tabel</returns>
        /// <exception cref="IndexOutOfRangeException"/>
        ITerm this[int index] { get; }

        /// <summary>
        /// Geeft een term in de gegeven taal
        /// </summary>
        /// <param name="index">de taal in de <see cref="IRosettaTabel"/> waaruit deze <see cref="ITermCombinatie"/> komt</param>
        /// <returns>1 term uit de tabel</returns>
        /// <exception cref="InvalidOperationException"/>
        ITerm this[ITaal taal] { get; }

    }

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

    public interface ITerm
    {
        ITaal Taal { get; }
        ITermCombinatie Combinatie { get; }

        string Term { get; set; }
    }

    #region input/output

    public interface IRosettaInput
    {
        IRosettaTabel Lees(Stream input);
        IRosettaTabel Lees(string bestandsnaam);
        IRosettaTabel Lees(FileInfo bestand);
    }

    public interface IRosettaTextInput : IRosettaInput
    {
        IRosettaTabel Lees(Stream input, Encoding encoding);
        IRosettaTabel Lees(string bestand, Encoding encoding);
        IRosettaTabel Lees(FileInfo bestand, Encoding encoding);
        IRosettaTabel Lees(TextReader input);
    }

    public interface IRosettaOutput
    {
        void Schrijf(IRosettaTabel rosettaTabel, Stream output);
        void Schrijf(IRosettaTabel rosettaTabel, string bestandsnaam);
        void Schrijf(IRosettaTabel rosettaTabel, FileInfo bestand);
    }

    public interface IRosettaTextOutput : IRosettaOutput
    {
        void Schrijf(IRosettaTabel rosettaTabel, TextWriter output);
        void Schrijf(IRosettaTabel rosettaTabel, Stream output, Encoding encoding);
    }

    public interface IRosettaIoFactory
    {
        IRosettaTextInput MaakHtmlInput();
        IRosettaTextOutput MaakHtmlOutput();
        IRosettaTextInput MaakCsvInput();
        IRosettaTextOutput MaakCsvOutput();
        IRosettaTextInput MaakTabDelimitedInput();
        IRosettaTextOutput MaakTabDelimitedOutput();

        IRosettaTextInput MaakXmlInput();
        IRosettaTextOutput MaakXmlOutput();
        IRosettaTextInput MaakJsonInput();
        IRosettaTextOutput MaakJsonOutput();

        IRosettaInput MaakExcelInput();
        IRosettaOutput MaakExcelOutput();

        //TODO: input/output voor SQLite en SQL Server (voorstel implementatie met ADO.NET)
        
    }
    #endregion

}
