using System.Text.Json;
using ScreenSound.modelos;

using (HttpClient client = new())
{

  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    // LinqOrder.ExibirListaDeArtistas(musicas);
    // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    // LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "pop");
    // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Billie Eilish");

    // MusicasPreferidas musicasPreferidasDoLucas = new("Lucas");
    // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[1]);
    // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[6]);
    // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[7]);
    // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[10]);
    // musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[28]);

    // musicasPreferidasDoLucas.ExibirMusicasFavoritas();

    MusicasPreferidas musicasPreferidasDoDuque = new("Duque");
    musicasPreferidasDoDuque.AdicionarMusicasFavoritas(musicas[15]);
    musicasPreferidasDoDuque.AdicionarMusicasFavoritas(musicas[456]);
    musicasPreferidasDoDuque.AdicionarMusicasFavoritas(musicas[89]);
    musicasPreferidasDoDuque.AdicionarMusicasFavoritas(musicas[241]);
    musicasPreferidasDoDuque.AdicionarMusicasFavoritas(musicas[12]);

    musicasPreferidasDoDuque.ExibirMusicasFavoritas();
    musicasPreferidasDoDuque.GerarArquivoJson();
  }
  catch (System.Exception ex)
  {
    System.Console.WriteLine($"Temos um problema: {ex.Message}");
  }
}