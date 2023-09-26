using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
  public class Venda
  {
    public int Id { get; set; }
    [JsonProperty("Nome_Produto")]
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataDaVenda { get; set; }
  }
}