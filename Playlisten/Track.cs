using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    internal class Track
    {
        //instans variable to name the tracks
        private string name;

        //encapsulation
        public string Name { get { return name; } }

        //constructor used to make the traks
        public Track(string name)
        {
            this.name = name;
        }
    }
}
