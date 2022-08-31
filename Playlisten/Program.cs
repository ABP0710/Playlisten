using System;

namespace Playlisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create 3 lists
            Playlist classicRock = new Playlist();
            Playlist powerMetal = new Playlist();
            Playlist rock = new Playlist();


            //create 6 songs
            Track SoS = new Track("Sound Of Silince");
            Track BmR = new Track("Bad moon rising");
            Track PiB = new Track("Paint it black");
            Track BiC = new Track("Back in controle");
            Track NW = new Track("Night witches");
            Track Her = new Track("Soldier of 3 armys");


            //adds 3 songs to the 1. playlist named classicRock
            classicRock.Tracks.Add(SoS);
            classicRock.Tracks.Add(BmR);
            classicRock.Tracks.Add(PiB);

            //adds 3 songs to the 2. playlist nemed powerMetal
            powerMetal.Tracks.Add(BiC);
            powerMetal.Tracks.Add(NW);
            powerMetal.Tracks.Add(Her);

            //adds all songs to the 3. playlist nemed rock
            rock.Tracks.Add(SoS);
            rock.Tracks.Add(BmR);
            rock.Tracks.Add(PiB);
            rock.Tracks.Add(BiC);
            rock.Tracks.Add(NW);
            rock.Tracks.Add(Her);

        }
    }
}
