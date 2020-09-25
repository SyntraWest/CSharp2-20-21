
namespace Rosetta.Interface
{
    /// <summary>
    /// Een combinatie van termen (<see cref="ITerm"/>) in verschillende talen (<see cref="ITaal"/>).
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
}
