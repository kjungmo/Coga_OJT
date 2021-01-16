using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseInterior
{
    class Room : Location
    {
        public string Decoration { get; private set; }

        public Room(string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public override string Description 
        { 
            get
            {
                return base.Description + " You see " + Decoration + ".";
            }
        }
    }
}
