using System;
using Iteration.songs;

namespace Iteration
{
    public class RdioStation
    {
          SongsOfThe70s songsOfThe70S = new SongsOfThe70s();
          SongsOfThe80s songsOfThe80S = new SongsOfThe80s();
          SongsOfThe90s songsOfThe90S = new SongsOfThe90s();

        

        //discJockeyMadMike
        public RdioStation()
        {
            DiscJockey discJockeyMadMike = new DiscJockey(songsOfThe70S,
               songsOfThe80S, songsOfThe90S);

            discJockeyMadMike.showTheSongs();
        }
    }
}
