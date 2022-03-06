using BattleFantasy.API.Base.Enums;
using BattleFantasy.API.Base.Interfaces;

namespace BattleFantasy.API.Base.Classes
{
    /// <summary>
    /// Represents the unit entity
    /// </summary>
    public class Unit : IUnit
    {
        /// <summary>
        /// Represents the unit name
        /// </summary>
        public string Name {get; private set;}

        /// <summary>
        /// Represents the current health of the unit
        /// </summary>
        public int Health { get; private set; }

        /// <summary>
        /// Represents the current position of the unit
        /// </summary>
        public ICell Position { get; private set; }

        /// <summary>
        /// This unit takes damage
        /// </summary>
        /// <param name="damage">Represents the damage received</param>
        public void GetHit(int damage)
        {
            if (damage >= Health) damage = Health;
            Health -= damage;
        }

        /// <summary>
        /// Moves the unit to a new cell
        /// </summary>
        /// <param name="newCell">Represents a new cell into which the unit will move</param>
        /// <returns>Returns the current position</returns>
        public ICell Move(ICell newCell)
        {
            Position = newCell;
            return Position;
        }

        /// <summary>
        /// Moves the unit to a new cell
        /// </summary>
        /// <param name="direction">Represents the direction of movement</param>
        /// <param name="steps">Represents the number of steps the unit will advance in the specified direction</param>
        /// <returns>Returns the current position</returns>
        public ICell Move(Directions direction, int steps)
        {
            switch (direction)
            {
                case Directions.Backward:
                    Position = new Cell(Position.X, Position.Y + steps);
                    break;
                case Directions.Forward:
                    Position = new Cell(Position.X, Position.Y - steps);
                    break;
                case Directions.Right:
                    Position = new Cell(Position.X + steps, Position.Y);
                    break;
                case Directions.Left:
                    Position = new Cell(Position.X - steps, Position.Y);
                    break;
                default:
                    break;
            }
            return Position;
        }

        /// <summary>
        /// Creates a unit entity
        /// </summary>
        /// <param name="name">Represents the unit name</param>
        /// <param name="health">Represents the health of the unit</param>
        /// <param name="position">Represents the cell where the unit will be placed</param>
        public Unit(string name, int health, ICell position)
        {
            Name = name;
            Health = health;
            Position = position;
        }
    }
}
