using System;
using System.Collections;
using System.Collections.Generic;
using Iteration.songs;

namespace Iteration
{
    public class DiscJockey
    {

        public SongsOfThe80s songsOfThe80S;
        public SongsOfThe70s songsOfThe70S;
        public SongsOfThe90s songsOfThe90S;

        public DiscJockey(SongsOfThe70s newsongsOfThe70S,
            SongsOfThe80s newsongsOfThe80S,
            SongsOfThe90s newsongsOfThe90S)
        {
            songsOfThe70S = newsongsOfThe70S;
            songsOfThe80S = newsongsOfThe80S;
            songsOfThe90S = newsongsOfThe90S;
        }

        public void showTheSongs()
        {
            List<SongInfo> all70s = songsOfThe70S.getBestSongs();
            Console.WriteLine("Songs of the 70 \n");
            foreach (var item in all70s)
            {
                Console.WriteLine(item.bandName + " "+ item.songName + "" +item.yearReleased.ToString());
            }

            SongInfo[] all80 = songsOfThe80S.getBestSongs();

            Console.WriteLine("Songs of the 80 \n");
            foreach (var item in all80)
            {
                Console.WriteLine(item.bandName + " " + item.songName + "" + item.yearReleased.ToString());
            }

            Hashtable all90 = songsOfThe90S.getBestSongs();
            for (int i = 0; i < all90.Count; i++)
            {
                SongInfo s = (SongInfo)all90[i];
                Console.WriteLine(s.bandName + " " + s.songName + "" + s.yearReleased.ToString());
            }
        }
    }
}
