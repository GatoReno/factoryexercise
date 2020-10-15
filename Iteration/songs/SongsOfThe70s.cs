using System;
using System.Collections.Generic;

namespace Iteration.songs
{
    public class SongsOfThe70s
    {
        public IList<SongInfo> bestSongs;

        public SongsOfThe70s()
        {
            bestSongs = new List<SongInfo>();
            bestSongs.Add(new SongInfo("i fet inlove","the cure", 1972) );
            bestSongs.Add(new SongInfo("i will survive", "gloria gaynor", 1978));
            bestSongs.Add(new SongInfo("guns end in the stairs", "the light", 1977));
        }

        public void addSong(string songName, string bandName, int yearReleased)
        {
            SongInfo songInfo = new SongInfo(songName,bandName, yearReleased);
            bestSongs.Add(songInfo);
        }

        public List<SongInfo> getBestSongs()
        {

            return (List<SongInfo>)bestSongs;
        }
    }
}
