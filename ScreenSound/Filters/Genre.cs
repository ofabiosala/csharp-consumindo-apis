using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class Genre
{
    public static void All(List<Song> songs)
    {
        var genres = songs.Select(song => song.Genre).Distinct().ToList();
        foreach (var genre in genres)
        {
            Console.WriteLine($"{genre}");
        }
    }
}

// Anotações

// LINQ (Language Integrated Query) é um recurso do C# que permite realizar consultas de dados diretamente no código.
// Utiliza termos semelhantes a sintaxe do "SQL" como: "Select", "Where", "Distinct", "OrderBy", "OrderByDescending", "GroupBy", "Join", "Aggregate", entre outros ...
// É aplicável a diversas fontes de dados, como arrays, listas, bancos de dados e XML, por exemplo.