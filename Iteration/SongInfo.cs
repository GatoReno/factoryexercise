using System;
namespace Iteration
{
    public class SongInfo
    {
        public string songName;
        public string bandName;
        public int yearReleased;


        public SongInfo(string newsongname, string newbandname,int newyear)
        {
            songName = newsongname;
            bandName = newbandname;
            yearReleased = newyear;
        }

        public string getSongName() { return songName; }
        public string getBandName() { return bandName; }
        public int getYearReleaed() { return yearReleased; }
    }
}
