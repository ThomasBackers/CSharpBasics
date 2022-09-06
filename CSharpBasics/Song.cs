using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aTitle, string anArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = anArtist;
            this.duration = aDuration;
            songCount++;
        }
    }
}
