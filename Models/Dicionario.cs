namespace ExemploExplorando.Models
{
  public class Dicionario
  {
    public void criaDicionario()
    {
      Dictionary<string, string> estados = new Dictionary<string, string>();

      estados.Add("SC", "Santa Catarina");
      estados.Add("RS", "Rio Grande do Sul");
      estados.Add("MG", "Minas Gerais");

      foreach (var estado in estados)
      {
        Console.WriteLine(@$"chave: {estado.Key}
valor: {estado.Value}");
      }

      Console.WriteLine("---------------");
      estados.Remove("MG");
      estados["RS"] = "rio grande do sul";

      foreach (var estado in estados)
      {
        Console.WriteLine(@$"chave: {estado.Key}
valor: {estado.Value}");
      }
    }
  }
}