// HttpClient
// Em C# o "HttpClient" é uma biblioteca utilizada para enviar requisições HTTP e receber respostas de serviços web.

using (HttpClient client = new HttpClient())
{
    // O "using" atual tem um contexto de gerenciar os recursos entre suas chaves.

    string url = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
    string res = await client.GetStringAsync(url);
    // HttpResponseMessage res = await client.GetAsync(url);

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

    Console.WriteLine(res);
}