using System;
using System.Collections;

namespace Iteration.songs
{
    public class SongsOfThe90s
    {
        public Hashtable bestSongs = new Hashtable();
        int arrval = 0;

        public SongsOfThe90s()
        {
            addSong("i fet inlove 2", "the cure", 1988);
            addSong("i will survive 2", "gloria gaynor", 1982);
            addSong("guns end in the stairs remix", "the light", 1987);
        }

        public void addSong(string songName, string bandName, int yearReleased)
        {
            SongInfo songInfo = new SongInfo(songName, bandName, yearReleased);
            bestSongs.Add(arrval, songInfo);
            arrval++;
        }

        public Hashtable getBestSongs()
        {

            return (Hashtable)bestSongs;
        }
    }
}


 