using System.Text.Json.Serialization;

namespace ScreenSound.Models;

internal class Song
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonality
    {
        get
        {
            return tonalities[Key];
        }
    }

    private string[] tonalities = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    public string DurationInMinutes
    {
        get
        {
            return $"{((Duration / 1000) / 60).ToString("D2")}:{((Duration / 1000) % 60).ToString("D2")}";
        }
    }

    public void Show()
    {
        Console.WriteLine($"Artista: {Artist}");
        Console.WriteLine($"Música: {Name}");
        Console.WriteLine($"Gênero: {Genre}");
        Console.WriteLine($"Ano: {Year}");
        Console.WriteLine($"Duração: {DurationInMinutes}");
        Console.WriteLine($"Tonalidade: {Tonality}");
    }
}

// Anotações

// Em C#, a anotação "JsonPropertyName" é usada para mapear propriedades de um objeto C# para nomes específicos de propriedades em JSON quando está serializando ou desserializando objetos JSON.
// Esta anotação é especialmente útil quando o nome da propriedade em JSON não corresponde exatamente ao nome da propriedade na classe C#.
// Caso o nome da propriedade na classe C# corresponder a propriedade em JSON não é necessário a utilização da anotação "JsonPropertyName". Lembrando que o "case sensitive" interfere.

// O método "ToString("D2")" formata o número como um inteiro com pelo menos dois dígitos. Se o número for menor que 10, ele será preenchido com um zero à esquerda.