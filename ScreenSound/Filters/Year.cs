using ModelSong = ScreenSound.Models.Song;

namespace ScreenSound.Filters;

internal class Year
{
    public static void ByYear(List<ModelSong> allSongs, string year)
    {
        var songsByYear = allSongs.Where(song => song.Year!.Equals(year)).ToList();

        Console.WriteLine($"Ano: {year}");
        Console.WriteLine($"Músicas:");

        foreach (var song in songsByYear)
        {
            Console.WriteLine($"> {song.Artist} - {song.Name}");
        }
    }
}
