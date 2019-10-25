using System;
using System.Collections.Generic;

namespace ChSt.DataBases
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var context = new MyDBContext())
            {

                var Rammstain = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };

                var LinkinPark = new Group()
                {
                    Name = "Linkin Park",
                    Year = 1997
                };
                

                context.Groups.Add(Rammstain);
                context.Groups.Add(LinkinPark);
                context.SaveChanges();


                var songs = new List<Song>
                {
                    new Song() { Name = "In the End", GroupId = LinkinPark.Id},
                    new Song() { Name = "Numb", GroupId = LinkinPark.Id},
                    new Song() { Name = "Matter", GroupId = Rammstain.Id}
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, group name: {song.Groups.Name}");
                }
                Console.WriteLine($"id: {LinkinPark.Id}, name: {LinkinPark.Name}, year: {LinkinPark.Year}");
                Console.ReadLine();
            }
        }
    }
}
