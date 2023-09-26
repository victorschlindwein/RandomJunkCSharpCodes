using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
  public class Vendas
  {
    public Vendas() { }
    public Vendas(int id, string produto, decimal preco)
    {
      Id = id;
      Produto = produto;
      Preco = preco;
    }
    public Vendas(int id, string produto, decimal preco, DateTime dataVenda)
    {
      Id = id;
      Produto = produto;
      Preco = preco;
      DataVenda = dataVenda;
    }
    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }

    public void NovaVenda(int id, string produto, decimal preco)
    {
      DateTime dataAtual = DateTime.Now;

      List<Vendas> listaVendas = new List<Vendas>();

      Vendas v1 = new Vendas(1, "Material de escritorio", 25M, dataAtual);
      Vendas v2 = new Vendas(2, "Licença de Software", 100M, dataAtual);
      Vendas v3 = new Vendas(id, produto, preco);

      listaVendas.Add(v1);
      listaVendas.Add(v2);
      listaVendas.Add(v3);

      string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

      File.WriteAllText("Arquivos/vendas.json", serializado);

      Console.WriteLine(serializado);
    }
  }
}