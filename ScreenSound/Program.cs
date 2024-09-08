using ScreenSound.Models;
using FilterArtist = ScreenSound.Filters.Artist;
using FilterGenre = ScreenSound.Filters.Genre;
using FilterSong = ScreenSound.Filters.Song;
using FilterYear = ScreenSound.Filters.Year;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string url = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";

    try
    {
        string res = await client.GetStringAsync(url);
        // HttpResponseMessage res = await client.GetAsync(url);
        // Console.WriteLine(res);
        var songs = JsonSerializer.Deserialize<List<Song>>(res)!;
        // Console.WriteLine(songs.Count);
        // songs[0].Show();
        // FilterArtist.OrderByAsc(songs);
        // FilterArtist.OrderByDesc(songs);
        // FilterArtist.ByGenre(songs, "R&B");
        // FilterArtist.ByGenre(songs, "pop");
        // FilterArtist.ByGenre(songs, "rock");
        // FilterGenre.All(songs);
        // FilterSong.ByArtist(songs, "My Chemical Romance");
        // FilterYear.ByYear(songs, "2017");
        FavoriteSongs favoriteSongsByFabio = new FavoriteSongs("Fábio");
        favoriteSongsByFabio.AddFavoriteSong(songs[175]);
        favoriteSongsByFabio.AddFavoriteSong(songs[610]);
        favoriteSongsByFabio.AddFavoriteSong(songs[918]);
        favoriteSongsByFabio.AddFavoriteSong(songs[71]);
        favoriteSongsByFabio.ShowFavoriteSongs();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ocorreu um erro: {e.Message}");
    }
}

// Anotações

// O "using" atual tem um contexto de gerenciar os recursos entre suas chaves.

// Em C# o "HttpClient" é uma biblioteca utilizada para enviar requisições HTTP e receber respostas de serviços web.

// Em C#, "async" e "await" são palavras-chave usadas em requisições assíncronas, ou seja, são operações que podem levar algum tempo para serem concluídas, como chamadas a APIs externas, por exemplo.
// Um método com a palavra-chave "async", indica que este pode conter operações assíncronas e que ele pode usar a palavra-chave "await".
// O método "async" deve retornar um tipo "Task". O uso de "async" permite que o método execute operações assíncronas sem bloquear a thread que o chamou.
// A palavra-chave "await" é usada dentro de um método "async" para indicar que a execução do método deve esperar a conclusão de uma tarefa assíncrona.
// Quando o "await" é utilizado, o código depois dele é "pausado" até que a tarefa que está sendo aguardada seja concluída. Isso não bloqueia a thread, mas permite que outros trabalhos sejam feitos enquanto aguarda a conclusão.

// O método "GetStringAsync" faz uma requisição HTTP do tipo "GET" para a URL fornecida e retorna o corpo da resposta como uma string diretamente.
// Este método é uma forma mais simplificada e direta de obter o conteúdo da resposta quando não é necessário acesso aos detalhes adicionais da requisição.
// Um uso típico do "GetStringAsync" é quando se torna necessário apenas o conteúdo da resposta e não os demais detalhes.

// O método "GetAsync" faz uma requisição HTTP do tipo "GET" para a URL fornecida e retorna um objeto do tipo "HttpResponseMessage" que contém a resposta completa do servidor.
// Um uso típico do "GetAsync" é quando se torna necessário o acesso a detalhes completos da resposta, como os cabeçalhos HTTP, o código de status da resposta, ou seja, quando é necessário manipular a resposta de maneira mais detalhada.

// Em C#, o bloco "try-catch" é uma estrutura de controle de exceções usada para tratar erros e exceções que podem ocorrer durante a execução do código. Exceções são eventos inesperados que interrompem o fluxo normal do programa.
// O bloco "try-catch" permite capturar exceções e tomar ações apropriadas para lidar com elas, garantindo que o programa continue a funcionar de maneira controlada ou informe ao usuário sobre o problema.
// O bloco "try" contém o código que pode causar uma exceção.
// O bloco "catch" captura a exceção e armazena em um objeto do tipo "Exception" que pode ser utilizado para exibir detalhes desta para o usuário.

// Em C#, "JsonSerializer" é uma classe fornecida pela biblioteca "System.Text.Json" para lidar com a "serialização" e "desserialização" de objetos JSON.
// A "serialização" (JsonSerializer.Serialize(object)) é o processo de converter um objeto em uma representação JSON.
// A "desserialização" (JsonSerializer.Deserialize<Class>(JSON)) é o processo inverso, ou seja, converter uma representação JSON de volta em um objeto C#.

// HTTP Status Code - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status