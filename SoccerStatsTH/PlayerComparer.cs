using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStatsTH
{
    public class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return x.pointsPerGame.CompareTo(y.pointsPerGame) * -1;
        }
    }
}
