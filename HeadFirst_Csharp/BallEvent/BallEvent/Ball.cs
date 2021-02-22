using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallEvent
{
    class Ball
    {
        public event EventHandler<BallEventArgs> BallInPlay;
        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            if (BallInPlay != null)
            {
                BallInPlay(this, e);
            }
        }
    }
}
