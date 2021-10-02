using System;

namespace EXSONG
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
    }
}
