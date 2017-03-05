using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10) { }

        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                if (random.Next(3) == 0 || random.Next(3) == 1)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(4, random);
            }
        }
    }
}
