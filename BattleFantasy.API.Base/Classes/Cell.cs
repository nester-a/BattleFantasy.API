using BattleFantasy.API.Base.Interfaces;

namespace BattleFantasy.API.Base.Classes
{
    public class Cell : ICell
    {
        // Represents the row in which the cell is located
        public int X {get; private set;}

        // Represents the column in which the cell is located
        public int Y { get; private set; }

        /// <summary>
        /// Creates a cell entity with two coordinates
        /// </summary>
        /// <param name="x">Represents the row in which the cell is located</param>
        /// <param name="y">Represents the column in which the cell is located</param>
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
