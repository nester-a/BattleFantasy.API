namespace BattleFantasy.API.Base.Interfaces
{
    public interface ICell
    {
        /// <summary>
        /// Represents the row in which the cell is located
        /// </summary>
        int X { get; }

        /// <summary>
        /// Represents the column in which the cell is located
        /// </summary>
        int Y { get; }
    }
}
