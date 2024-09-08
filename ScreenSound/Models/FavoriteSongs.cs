using ScreenSound.Filters;

namespace ScreenSound.Models;

internal class FavoriteSongs
{
    public string Person { get; set; }
    public List<Song> Songs { get; set; }

    public FavoriteSongs(string person)
    {
        Person = person;
        Songs = new List<Song>();
    }

    public void AddFavoriteSong(Song song)
    {
        Songs.Add(song);
    }

    public void ShowFavoriteSongs()
    {
        Console.WriteLine($"Músicas Favoritas de {Person}");
        foreach (var song in Songs)
        {
            Console.WriteLine($"> {song.Artist} - {song.Name}");
        }
    }
}
