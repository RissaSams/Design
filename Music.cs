using System;
using System.Collections.Generic;
using System.Text;

namespace Design
{
    class Music
    {
        string genre, singer, album;
        int year;

        public Music(string genre, string singer, string album, int year)
        {
            this.Genre = genre;
            this.Singer = singer;
            this.Album = album;
            this.Year = year;
        }

        public string Genre { get => genre; set => genre = value; }
        public string Singer { get => singer; set => singer = value; }
        public string Album { get => album; set => album = value; }
        public int Year { get => year; set => year = value; }

        public override string ToString()
        {
            return Singer + " sings " + Genre + ". \nOne of their albums is " + Album + " and it was released in " + Year + ".";
        }
    }
}
