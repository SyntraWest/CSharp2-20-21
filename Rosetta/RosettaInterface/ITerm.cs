namespace Rosetta.Interface
{
    /// <summary>
    /// 1 term in 1 taal in een <see cref="IRosettaTabel"/>
    /// </summary>
    public interface ITerm
    {
        ITaal Taal { get; }
        ITermCombinatie Combinatie { get; }

        string Term { get; set; }
    }
}
