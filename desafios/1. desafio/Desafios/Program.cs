using Desafios.menus;

class Program
{
  static void Main(string[] args)
  {
    string accountType;
    float balance = 100;
    int option = 0;

    System.Console.WriteLine("Deseja criar uma conta? Me informe alguns dados.\n");
    System.Console.Write("Qual o seu nome? ");
    string name = Console.ReadLine()!;

    System.Console.WriteLine("\nIrá criar uma conta conta Corrente ou Poupança? ");
    System.Console.Write("[ 1 ] Corrente [ 2 ] Poupança: ");
    int choice = int.Parse(Console.ReadLine()!);

    
    accountType = choice == 1 ? "Corrente" : "Poupança";


    void ExibirOpcoesDoMenu()
    {
      Console.Clear();

      System.Console.WriteLine(@$"
*******************************************
Dados do cliente:

Nome: {name}
Tipo de conta: {accountType}
Saldo: {balance.ToString("C")}
*******************************************
      ");

      System.Console.Write(@"
Operações

1 - Consultar saldo
2 - Depositar valor
3 - Transferir valor
4 - Sair

Digite a opções desejada: 
");
    }

    ExibirOpcoesDoMenu();

    while (option != 4)
    {
      option = int.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 1:
          new MenuConsultarSaldo().Executar(balance);
          break;
        case 2:
          float value2 = new MenuDepositarValor().Executar(balance);
          balance += value2;
          break;
        case 3:
          float value3 = new MenuTransferirValor().Executar(balance);
          balance -= value3;
          break;
        case > 4:
          new MenuInvalido().Executar(option);
          break;
      }

      if (option != 4) ExibirOpcoesDoMenu();
    }

    Thread.Sleep(2000);
    Console.Clear();
    System.Console.WriteLine("Até a próxima :)");
  }
}