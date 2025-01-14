using System.Text.Json.Serialization;

namespace ScreenSound.modelos;

internal class Musica
{
  private string[] tonalidades = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];

  // A prop Nome referencia o campo song do Json
  [JsonPropertyName("song")]
  public string? Nome { get; set; }

  [JsonPropertyName("artist")]
  public string? Artista { get; set; }

  [JsonPropertyName("duration_ms")]
  public int? Duracao { get; set; }

  [JsonPropertyName("genre")]
  public string? Genero { get; set; }

  [JsonPropertyName("key")]
  public int Key { get; set; }

  public string Tonalidade 
  {
    get
    {
      return this.tonalidades[this.Key];
    }
  }

  public void ExibirDetalhesDaMusica() {
    System.Console.WriteLine($"\nArista: {this.Artista}");
    System.Console.WriteLine($"Música: {this.Nome}");
    System.Console.WriteLine($"Duracão: {this.Duracao / 1000}");
    System.Console.WriteLine($"Genero: {this.Genero}");
    System.Console.WriteLine($"Tonalidade: {this.Tonalidade}");
  }
}