using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Victor", "Schlindwein");
Console.WriteLine(p1.NomeCompleto);

(string nome, string sobrenome) = p1;

Console.WriteLine(nome);
Console.WriteLine(sobrenome);