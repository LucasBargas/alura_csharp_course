namespace ScreenSound.modelos;
internal class Avaliacao(int nota)
{
  public int Nota { get; } = nota;

  public static Avaliacao Parse(string texto) 
  {
    int nota = int.Parse(texto);
    return new Avaliacao(nota);
  }
}