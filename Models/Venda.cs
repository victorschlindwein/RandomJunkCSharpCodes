using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
  public class Venda
  {
    public int Id { get; set; }
    [JsonProperty("Nome_Produto")]
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    [JsonProperty("DataVenda")]
    public DateTime DataDaVenda { get; set; }

    public void LeArquivo()
    {
      string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
      List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

      foreach (Venda venda in listaVendas)
      {
        Console.WriteLine($"Id: {venda.Id}, produto: {venda.Produto}, preco: {venda.Preco}, Data: {venda.DataDaVenda}");
        Thread.Sleep(500);
      }
    }
  }
}