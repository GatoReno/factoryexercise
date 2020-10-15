using System;
using System.Collections;
using System.Collections.Generic;

namespace composite.objects
{
    public class SongGroup : SongComponent
    {
        IList songComponentsList;
        public string groupName;
        public string groupDescription;

        public SongGroup(string newGroupName, string newGroupDescription)
        {
            groupName = newGroupName;
            groupDescription = newGroupDescription;
            songComponentsList = new List<SongComponent>();
        }

        public string getGroupName() { return groupName; }
        public string getGroupDescription() { return groupDescription; }

        public void Add(SongComponent newSongComponent)
        {
            songComponentsList.Add(newSongComponent);
        }

        public void Remove(SongComponent deleteSongComponent)
        {
            songComponentsList.Remove(deleteSongComponent);
        }

        public SongComponent getComponent(int id)
        {
            SongComponent xs = (SongComponent)songComponentsList[id];

            return xs;
        }

        public void displaySongInfo()
        {
            Console.WriteLine();
        }

    }
   
}
