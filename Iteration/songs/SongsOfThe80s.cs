using System;
using System.Collections.Generic;
namespace Iteration.songs
{
    public class SongsOfThe80s
    {
        public SongInfo[] bestSongs;
        int arrval = 0;
        public SongsOfThe80s()
        {
            bestSongs = new SongInfo[3];

            addSong("i fet inlove 2", "the cure", 1988);
            addSong("i will survive 2", "gloria gaynor", 1982);
            addSong("guns end in the stairs remix", "the light", 1987);
        }

        public void addSong(string songName, string bandName, int yearReleased)
        {
            SongInfo songInfo = new SongInfo(songName, bandName, yearReleased);
            bestSongs[arrval] = songInfo;
            arrval ++;
        }

        public SongInfo[] getBestSongs()
        {

            return (SongInfo[])bestSongs;
        }
    }
}

 


