using BattleFantasy.API.Base.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFantasy.API.Base.Interfaces
{
    public interface IMovable
    {
        ICell Move(ICell newCell);
        ICell Move(Directions direction, int step);
    }
}
