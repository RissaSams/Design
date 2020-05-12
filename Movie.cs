using System;
using System.Collections.Generic;
using System.Text;

namespace Design
{
    class Movie
    {
        string director, title, length;
        int year;

        public Movie(string director, string title, string length, int year)
        {
            this.Director = director;
            this.Title = title;
            this.Length = length;
            this.Year = year;
        }

        public string Director { get => director; set => director = value; }
        public string Title { get => title; set => title = value; }
        public string Length { get => length; set => length = value; }
        public int Year { get => year; set => year = value; }

        public override string ToString()
        {
            return Title + " was directed by " + Director + ". \nIt was released in " + Year + " and the movie was " + length + " long.";
        }
    }
}
