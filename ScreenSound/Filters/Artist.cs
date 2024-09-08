using ModelSong = ScreenSound.Models.Song;

namespace ScreenSound.Filters;

internal class Artist
{
    public static void OrderByAsc(List<ModelSong> songs)
    {
        var artists = songs.OrderBy(song => song.Artist).Select(song => song.Artist).Distinct().ToList();

        Console.WriteLine($"Artistas (A > Z):");

        foreach (var artist in artists)
        {
            Console.WriteLine($"> {artist}");
        }
    }

    public static void OrderByDesc(List<ModelSong> songs)
    {
        var artists = songs.OrderByDescending(song => song.Artist).Select(song => song.Artist).Distinct().ToList();

        Console.WriteLine($"Artistas (Z > A):");

        foreach (var artist in artists)
        {
            Console.WriteLine($"> {artist}");
        }
    }

    public static void ByGenre(List<ModelSong> songs, string genre)
    {
        var artists = songs.Where(song => song.Genre!.Contains(genre)).Select(song => song.Artist).Distinct().ToList();
        // var artists = songs.OrderBy(song => song.Artist).Where(song => song.Genre!.Contains(genre)).Select(song => song.Artist).Distinct().ToList();

        Console.WriteLine($"Gênero: {genre}");
        Console.WriteLine($"Artistas:");

        foreach (var artist in artists)
        {
            Console.WriteLine($"> {artist}");
        }
    }
}
