using (HttpClient client = new())
{
  
  try
  {
  string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    System.Console.WriteLine(resposta);
  }
  catch (System.Exception ex)
  {
    System.Console.WriteLine($"Temos um problema: {ex.Message}");
  }
}

