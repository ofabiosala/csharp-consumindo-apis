using ModelSong = ScreenSound.Models.Song;

namespace ScreenSound.Filters;

internal class Song
{
    public static void ByArtist(List<ModelSong> allSongs, string artist)
    {
        var songsByArtist = allSongs.Where(song => song.Artist!.Equals(artist)).ToList();

        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Músicas:");

        foreach (var song in songsByArtist)
        {
            Console.WriteLine($"> {song.Name}");
        }
    }
}
