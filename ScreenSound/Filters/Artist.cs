using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class Artist
{
    public static void OrderByAsc(List<Song> songs)
    {
        var artists = songs.OrderBy(song => song.Artist).Select(song => song.Artist).Distinct().ToList();
        foreach (var artist in artists)
        {
            Console.WriteLine($"{artist}");
        }
    }

    public static void OrderByDesc(List<Song> songs)
    {
        var artists = songs.OrderByDescending(song => song.Artist).Select(song => song.Artist).Distinct().ToList();
        foreach (var artist in artists)
        {
            Console.WriteLine($"{artist}");
        }
    }
}
