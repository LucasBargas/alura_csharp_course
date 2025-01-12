namespace Desafios.menus;

internal class MenuTransferirValor: Menu
{
  public float Executar(float balance)
  {
    Console.Clear();

    System.Console.Write("Qual o valor que deseja transferir? ");
    float value = float.Parse(Console.ReadLine()!);
    
    if (value > balance) 
    {
      System.Console.WriteLine("Você não possui saldo suficiente para realizar estar transferência :(");
      LimparNavegacao();
      return 0;
    }
    else
    {
      System.Console.WriteLine($"\nVocê transferiu: {value.ToString("C")}");
      LimparNavegacao();
      return value;
    }
    
  }
}