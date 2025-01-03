class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    public void DefineDisponivel(bool value)
    {
        this.disponivel = value;
    }

    public bool PegaDisponivel()
    {
        return disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {this.nome}");
        Console.WriteLine($"Artista: {this.artista}");
        Console.WriteLine($"Duracao: {this.duracao}");
        Console.WriteLine($"Artista: {this.artista}");

        string message = this.disponivel ? "Disponível no plano" : "Não disponível no plano";
        Console.WriteLine(message);
    }
}
