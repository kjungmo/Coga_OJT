using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekInTheHouse
{
    class Opponent
    {
        private Random random;
        private Location myLocation;
        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        public void move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                    if (random.Next(2) == 1)
                        myLocation = locationWithDoor.DoorLocation;
                }
                int rand = random.Next(myLocation.exits.Length);
                myLocation = myLocation.exits[rand];
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }

        public bool check( Location locationToCheck )
        {
            if (locationToCheck != myLocation)
                return false;
            else
                return true;
        }
    }
}
