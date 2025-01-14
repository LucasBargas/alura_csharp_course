using System.Linq;
using ScreenSound.modelos;
using System.Threading.Tasks;

internal class LinqOrder
{
  public static void ExibirListaDeArtistas(List<Musica> musicas)
  {
    // Ordenar aristas por A/Z
    var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
    System.Console.WriteLine("Lista de artistas ordenados:");
    foreach (var artista in artistasOrdenados)
    {
      System.Console.WriteLine($"- {artista}");
    }
  }
}