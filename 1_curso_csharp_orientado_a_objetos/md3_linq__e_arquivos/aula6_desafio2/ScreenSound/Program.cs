using System.Text.Json;
using ScreenSound.modelos;

using (HttpClient client = new())
{

  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    LinqFilter.FiltrarMusicasEmDoSustenido(musicas);

    // musicas[0].ExibirDetalhesDaMusica();
  }
  catch (System.Exception ex)
  {
    System.Console.WriteLine($"Temos um problema: {ex.Message}");
  }
}