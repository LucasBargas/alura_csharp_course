namespace Desafios.menus;

internal class MenuDepositarValor: Menu
{
  public float Executar(float balance)
  {
    Console.Clear();

    System.Console.Write("Qual o valor que deseja depositar? ");
    float value = float.Parse(Console.ReadLine()!);

    System.Console.WriteLine($"\nVocê depositou: {value.ToString("C")}");
    LimparNavegacao();
    return value;
  }
}