using Desafios.modelos;

class Program
{
  static void Main(string[] args)
  {
    /*
    
    8mk*/
    List<Pessoa> listaDePessoas = [];

    Pessoa lucas = new("Lucas", 24);
    Pessoa pedro = new("Pedro", 15);
    Pessoa vitor = new("Vitor", 23);

    listaDePessoas.Add(lucas);
    listaDePessoas.Add(pedro);
    listaDePessoas.Add(vitor);
    
    foreach (var item in listaDePessoas)
    {
      System.Console.WriteLine(item);
    }

    System.Console.WriteLine($"\nNúmero de pessoas na lista {listaDePessoas.Count()}");
    System.Console.WriteLine($"\nPrimeira pessoa da lista {listaDePessoas[0]}");
  }
}