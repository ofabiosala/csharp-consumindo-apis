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

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    public string DurationInMinutes
    {
        get
        {
            return $"{Duration / 1000}:{(Duration % 1000).ToString("D2")}";
        }
    }

    public void Show()
    {
        Console.WriteLine($"{Artist} - {Name} - {Genre} - {DurationInMinutes}");
    }
}

// Anotações

// Em C#, a anotação "JsonPropertyName" é usada para mapear propriedades de um objeto C# para nomes específicos de propriedades em JSON quando está serializando ou desserializando objetos JSON.
// Esta anotação é especialmente útil quando o nome da propriedade em JSON não corresponde exatamente ao nome da propriedade na classe C#.

// O método "ToString("D2")" formata o número como um inteiro com pelo menos dois dígitos. Se o número for menor que 10, ele será preenchido com um zero à esquerda.