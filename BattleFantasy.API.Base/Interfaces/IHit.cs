using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFantasy.API.Base.Interfaces
{
    public interface IHitable
    {
        void GetHit(int damage);
    }
}
