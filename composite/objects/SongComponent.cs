using System;
namespace composite.objects
{
    public abstract class SongComponent
    {
        public void add(SongComponent songComponent)
        {


        }

        public void remove(SongComponent songComponent)
        {


        }

        public SongComponent getSongComponent(int songComponent)
        {
            throw new ExecutionEngineException();
        }

        public string getSongName()
        {
            return "";
        }

        public string getBandName()
        {
            return "";
        }

        public int getReleaseYear()
        {
            return 0;
        }

        public void displaySongInfo()
        {

        }

    }
}
