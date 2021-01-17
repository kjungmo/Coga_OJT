using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekInTheHouse
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription, string hidingPlaceName) : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }

        public Location DoorLocation { get; set; }
        public string DoorDescription { get; private set; }

    }
}
