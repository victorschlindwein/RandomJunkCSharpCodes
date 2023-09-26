using ExemploExplorando.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVendas)
{
  Console.WriteLine($"Id: {venda.Id}, produto: {venda.Produto}, preco: {venda.Preco}, Data: {venda.DataDaVenda}");
  Thread.Sleep(500);
}