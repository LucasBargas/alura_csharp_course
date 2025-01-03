public class Podcast
{
    private List<Episodio> episodios = [];
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpsiodios => this.episodios.Count;

    public Podcast(string nome, string host)
    {
        this.Nome = nome;
        this.Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {this.Nome}, apresentado por {this.Host}\n");

        Console.WriteLine("Episódios:");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        string total = this.episodios.Count == 0 || this.episodios.Count > 1 ? "episódios" : "episódio";

        Console.WriteLine($"\nTotal de episódios: {this.TotalEpsiodios} {total}");
    }
}