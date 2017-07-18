using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var songs = new List<Song>();
        var numberOfSongs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfSongs; i++)
        {
            try
            {
                var inputLine = Console.ReadLine().Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                var indexSeparator = inputLine[2].IndexOf(':');
                var timeInfo = inputLine[2].Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine.Length < 3 || indexSeparator < 1 || indexSeparator > inputLine[2].Length - 2)
                {
                    throw new InvalidSongException();
                }
                var song = new Song(inputLine[0], inputLine[1], int.Parse(timeInfo[0]), int.Parse(timeInfo[1]));
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Invalid song length.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
        int totalDuration = 0;
        foreach (var song in songs)
        {
            totalDuration += song.Minutes * 60 + song.Seconds;
        }
        int hours = totalDuration / 3600;
        totalDuration -= hours * 3600;
        int minutes = totalDuration / 60;
        totalDuration -= minutes * 60;
        int seconds = totalDuration;


        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
    }
}

