public class Episodio
{
    private List<string> convidados = [];
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"{this.Ordem}. {this.Titulo} ({this.Duracao} min) - {string.Join(", ", this.convidados)}";

    public Episodio(int ordem, string titulo, int duracao)
    {
        this.Ordem = ordem;
        this.Titulo = titulo;
        this.Duracao = duracao;
    }

    public void AdicionaConvidado(string convidado)
    {
        this.convidados.Add(convidado);
    }
}
