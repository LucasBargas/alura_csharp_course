namespace ScreenSound.modelos;

internal interface IAvaliavel
{
  void AdicionarNota(Avaliacao nota);
  double Media { get; }
}