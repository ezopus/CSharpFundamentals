using System;
using System.Collections.Generic;

namespace L03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                Song oneSong = new Song(input[0], input[1], input[2]);
                songs.Add(oneSong);
            }
            string lastLine = Console.ReadLine();
            if (lastLine == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == lastLine)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
