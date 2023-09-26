namespace ExemploExplorando.Fila
{
  public class Fila
  {
    public void CriaFila()
    {
      Queue<int> fila = new Queue<int>();

      int costumer = 1;
      for (int i = 0; i < 5; i++)
      {
        fila.Enqueue(costumer + i);
        Console.WriteLine($"Adicionando o item {i}");
      }

      fila.Enqueue(19);

      Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
      Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
      Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

      foreach (int item in fila)
      {
        Console.WriteLine(item);
      }
    }
  }
}