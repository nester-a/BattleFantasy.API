namespace BattleFantasy.API.Base.Interfaces
{
    public interface IFraction : IName
    {
        List<IUnit> Units { get; }
    }
}
