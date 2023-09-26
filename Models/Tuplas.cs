namespace ExemploExplorando.Models
{
  public class Tuplas
  {
    public void CriaTuplas()
    {
      (int Id, string Nome, string Sobrenome) tupla = (1, "vitor luiz", "rovaris");

      ValueTuple<int, string, string> outraTupla = (2, "nicolas", "pexoto");

      var maisUmaTupla = Tuple.Create(3, "iago", "floriani");

      Console.WriteLine(tupla.Id);
      Console.WriteLine(tupla.Nome);
      Console.WriteLine(tupla.Sobrenome);
      Console.WriteLine(tupla.ToString());

      Console.WriteLine($"Valores informados {outraTupla.ToString()}");

      Console.WriteLine($"olha ela ai novamente {maisUmaTupla.ToValueTuple()}");
    }
  }
}