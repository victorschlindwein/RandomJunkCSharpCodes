namespace ExemploExplorando.Models
{
  public class LeituraArquivo
  {
    public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
    {
      try
      {
        string[] linhas = File.ReadAllLines(caminho);
        return (true, linhas, linhas.Length);
      }
      catch
      {
        return (false, Array.Empty<string>(), 0);
      }
    }
  }
}