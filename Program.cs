using System;

namespace Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone myPhone = new Phone("Samsung", "Galaxy Note", 10);
            Console.WriteLine(myPhone);
            Phone momPhone = new Phone("Samsung", "Galaxy J", 7);
            Console.WriteLine(momPhone);

            Music firstSinger = new Music("Alternative Rock", "Linkin Park", "Meteora", 2003);
            Console.WriteLine(firstSinger);
            Music secondSinger = new Music("Country", "Carrie Underwood", "Play On", 2009);
            Console.WriteLine(secondSinger);

            Movie firstMovie = new Movie("James Wan", "Aquaman", "2h 22m", 2018);
            Console.WriteLine(firstMovie);
            Movie secondMovie = new Movie("Patricia Riggen", "Miracles from Heaven", "1h 49m", 2016);
            Console.WriteLine(secondMovie);
        }
    }
}
