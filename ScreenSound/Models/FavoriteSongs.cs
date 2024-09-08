using ScreenSound.Filters;
using System.Text.Json;

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
        Console.WriteLine($"Músicas Favoritas de {Person}:");

        foreach (var song in Songs)
        {
            Console.WriteLine($"> {song.Artist} - {song.Name}");
        }
    }

    public void ExportFavoriteSongsToJson()
    {
        string json = JsonSerializer.Serialize(new { pessoa = Person, musicas = Songs });
        string fileName = $"musicas-favoritas-de-{Person.ToLower()}.json";
        // string fileName = $"C:\\Users\\Fabio\\musicas-favoritas-de-{Person.ToLower()}.json";

        try
        {
            File.WriteAllText(fileName, json);

            Console.WriteLine($"Arquivo JSON gerado com sucesso em: {Path.GetFullPath(fileName)}");
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}

// Anotações

// Objetos anônimos são úteis quando se torna necessário criar um objeto temporário sem precisar definir uma classe específica para ele.
// Eles são frequentemente utilizados para armazenar dados de forma simples e rápida.
// Devido à natureza dos objetos anônimos, não é possível alterar suas propriedades após sua criação.

// "ToLower" é um método da classe String que converte todos os caracteres de uma string para minúsculas.

// Em C#, a classe "File" fornece métodos estáticos que permitem realizar operações básicas de manipulação de arquivos.
// Essa classe oferece uma interface conveniente para criar, copiar, mover, excluir e acessar arquivos no sistema de arquivos.

// "WriteAllText" é utilizado para criar um novo arquivo, ou substituir um arquivo existente, com o conteúdo fornecido.
// Este método recebe dois parâmetros sendo o primeiro o "path", ou seja, uma string que especifica o caminho completo juntamente com o nome do arquivo a criar ou substituir. O segundo é uma string que representa o conteúdo do arquivo.
// Caso seja informado apenas o nome do arquivo, o caminho padrão é o diretório de "binários" do projeto.

// A classe "Path" fornece métodos e propriedades estáticos para manipulação e análise de caminhos de arquivos e diretórios.
// Esta classe é projetada para simplificar o trabalho com caminhos de arquivos, oferecendo uma maneira de construir, modificar e obter informações sobre caminhos de arquivos.

// GetFullPath é utilizado para obter o "caminho absoluto" de um "caminho relativo".
// Isso é útil quando você precisa transformar um caminho relativo (por exemplo, "file.txt") em um caminho absoluto que inclui a unidade e diretório raiz do sistema de arquivos (por exemplo, "C:\Users\UserOne\Files\file.txt")