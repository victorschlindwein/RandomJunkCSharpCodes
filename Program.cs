using System.IO.Pipes;
using ExemploExplorando.Models;

/* Exemplo de implementação usando tuplas. */
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhas, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
  // Console.WriteLine($"Identificadas {quantidadeDeLinhas} linhas");
  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
else
{
  Console.WriteLine("Algo deu errado");
}
