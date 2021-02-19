using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallEvent
{
    class BallEventArgs : EventArgs
    {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }
        public BallEventArgs (int Trajectory, int Distance)
	{
            this.Trajectory = Trajectory;
            this.Distance = Distance;
	}
    }
}
