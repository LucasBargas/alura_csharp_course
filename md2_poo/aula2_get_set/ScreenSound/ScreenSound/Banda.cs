class Banda
{
    private List<Album> albums = [];
    public string Nome { get; }

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        this.albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Exibir discografia da banda: {this.Nome}");

        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal} segundos)");
        }
    }
}