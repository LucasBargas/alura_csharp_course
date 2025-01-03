class Album
{ 
    private List<Musica> musicas = [];
    public string Nome { get; }
    // Valor já definido, não sendo possível altera-lo (set), apenas lê-lo (get)
    // Lambda
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public Album(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {this.Nome}:\n");

        foreach (var musica in this.musicas)
        {
            Console.WriteLine(musica.Nome);
        }

        Console.WriteLine($"\nPara ouvir este álbum interiro você precisa de {this.DuracaoTotal} segundos");
    }
}