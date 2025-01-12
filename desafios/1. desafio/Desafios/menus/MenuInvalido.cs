namespace Desafios.menus;

internal class MenuInvalido: Menu
{
  public void Executar(int option)
  {
    System.Console.WriteLine("Opção inválida :(");
    LimparNavegacao();
  }
}