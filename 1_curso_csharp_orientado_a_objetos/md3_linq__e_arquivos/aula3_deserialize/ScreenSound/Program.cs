using System.Text.Json;
using ScreenSound.modelos;

using (HttpClient client = new())
{

  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    // System.Console.WriteLine(resposta);

    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    musicas[1996].ExibirDetalhesDaMusica();
  }
  catch (System.Exception ex)
  {
    System.Console.WriteLine($"Temos um problema: {ex.Message}");
  }
}

