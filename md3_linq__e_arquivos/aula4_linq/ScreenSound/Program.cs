using System.Text.Json;
using ScreenSound.modelos;

using (HttpClient client = new())
{

  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    LinqOrder.ExibirListaDeArtistas(musicas);
    LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
    LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Billie Eilish");
  }
  catch (System.Exception ex)
  {
    System.Console.WriteLine($"Temos um problema: {ex.Message}");
  }
}