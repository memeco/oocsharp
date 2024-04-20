using System;
using CadastroPessoa;
using Documentos;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("João Silva", new DateTime(1990, 5, 15));

        RG rg = new RG("1234567", new DateTime(2000, 6, 20));
        CNH cnh = new CNH("ABC1234", new DateTime(2010, 7, 25));
        
        pessoa.AdicionarDocumento(rg);
        pessoa.AdicionarDocumento(cnh);

        Console.WriteLine($"Nome: {pessoa.Nome}");
        Console.WriteLine($"Data de Nascimento: {pessoa.DataNascimento.ToShortDateString()}");
        Console.WriteLine("Documentos:");

        foreach (var documento in pessoa.Documentos)
        {
            Console.WriteLine($"Tipo: {documento.Tipo}, Data de Emissão: {documento.DataEmissao.ToShortDateString()}");
            documento.ExibirDetalhes();
        }

        Console.ReadKey();
    }
}
