class Musica
{
    public string Nome {  get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    // Valor já definido, não sendo possível altera-lo (set), apenas lê-lo (get)
    // Lambda
    public string DescricaoResumida => 
        $"A música {this.Nome} pertence a banda {this.Artista}";

    public Musica(Banda artista, string nome)
    {
        this.Nome = nome;
        this.Artista = artista;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Artista: {this.Artista.Nome}");
        Console.WriteLine($"Duracao: {this.Duracao}");

        string message = this.Disponivel ? "Disponível no plano" : "Não disponível no plano";
        Console.WriteLine(message);
    }
}
