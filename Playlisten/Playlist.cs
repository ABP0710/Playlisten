using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    internal class Playlist
    {
        //instans variable to name the lists
        //the List is used as my datatype and named tracks
        private string name;
        private List<Track> tracks;

        //encapsulation of my lists
        public List<Track> Tracks { get { return tracks; } set { tracks = value; } }
        public string Name { get { return name; } set { name = value; } }

        //constructor used to make the lists
        public Playlist()
        {
            tracks = new List<Track>()
            {
                
            };
        }

    }
}
