namespace Desafios.menus;

internal class MenuConsultarSaldo: Menu
{
  public void Executar(float balance)
  {
    Console.Clear();
    System.Console.WriteLine($"Seu saldo atual é de: {balance}");
    LimparNavegacao();
  }
}