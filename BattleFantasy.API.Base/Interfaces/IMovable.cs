using BattleFantasy.API.Base.Enums;

namespace BattleFantasy.API.Base.Interfaces
{
    public interface IMovable
    {
        ICell Move(ICell newCell);
        ICell Move(Directions direction, int steps);
    }
}
