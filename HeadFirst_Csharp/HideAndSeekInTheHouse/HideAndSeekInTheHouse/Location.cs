using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekInTheHouse
{
    abstract class Location
    {
        public Location(string name)
        {
            Name = name;
        }

        public Location[] exits;

        public string Name { get; private set; }

        public virtual string Description 
        { 
            get
            { 
                string description = "You're standing in the " + Name + ". You see exits to the following places: ";
                for (int i = 0; i < exits.Length; i++)
			    {
                    description += " " + exits[i].Name;
                    if (i != exits.Length - 1)
                        description += ",";
			    }
                description += ".";
                return description;
            }
         }
    }
}
