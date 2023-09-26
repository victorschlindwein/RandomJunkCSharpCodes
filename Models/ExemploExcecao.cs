namespace ExemploExplorando.ExemploExcecao
{
  public class ExemploExcecao
  {
    public void Metodo1()
    {
      try
      {
        Console.WriteLine("Passou pelo método 1 com sucesso, chamando o método 2");
        Thread.Sleep(500);
        Metodo2();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
      }
    }

    public void Metodo2()
    {
      Console.WriteLine("Passou pelo método 2 com sucesso, chamando o método 3");
      Thread.Sleep(500);
      Metodo3();
    }

    public void Metodo3()
    {
      Console.WriteLine("Passou pelo método 3 com sucesso, chamando o método 4");
      Thread.Sleep(500);
      Metodo4();
    }

    public void Metodo4()
    {
      throw new Exception("Ocorreu uma exceção, método 4 está OUT");
    }
  }
}