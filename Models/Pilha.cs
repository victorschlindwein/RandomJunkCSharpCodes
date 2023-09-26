namespace ExemploExplorando.Pilha
{
  public class Pilha
  {
    public void CriaPilha()
    {
      Stack<int> pilha = new Stack<int>();

      int costumer = 1;
      for (int i = 1; i < 5; i++)
      {
        pilha.Push(costumer + i);
        Console.WriteLine($"Adicionando o item {i}");
      }

      int numeroAleatorio = 19;
      Console.WriteLine($"Adicionando o item {numeroAleatorio}");
      pilha.Push(numeroAleatorio);

      Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
      Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
      Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

      foreach (int item in pilha)
      {
        Console.WriteLine(item);
      }
    }
  }
}