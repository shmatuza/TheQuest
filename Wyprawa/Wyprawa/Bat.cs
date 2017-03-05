using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6) { }

        public override void Move(Random random)
        {
            if(HitPoints >= 1)
            {
                if (random.Next(1) == 1)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                else
                {
                    Direction direction = (Direction)random.Next(4);
                    location = Move(direction, game.Boundaries);
                }

                if (this.NearPlayer())
                    game.HitPlayer(2, random);
            }
        }

    }
}
