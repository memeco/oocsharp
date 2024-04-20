using System;

namespace Documentos
{
    public abstract class Documento : IDocumento
    {
        public abstract string Tipo { get; protected set; }
        public DateTime DataEmissao { get; set; }

        public Documento(DateTime dataEmissao)
        {
            DataEmissao = dataEmissao;
        }

        public abstract void ExibirDetalhes();
    }

    public class RG : Documento
    {
        public override string Tipo { get; protected set; } = "RG";
        public string Numero { get; set; }

        public RG(string numero, DateTime dataEmissao) : base(dataEmissao)
        {
            Numero = numero;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
        }
    }

    public class CNH : Documento
    {
        public override string Tipo { get; protected set; } = "CNH";
        public string Numero { get; set; }

        public CNH(string numero, DateTime dataEmissao) : base(dataEmissao)
        {
            Numero = numero;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
        }
    }

    public class CTPS : Documento
    {
        public override string Tipo { get; protected set; } = "CTPS";
        public string Numero { get; set; }

        public CTPS(string numero, DateTime dataEmissao) : base(dataEmissao)
        {
            Numero = numero;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
        }
    }

    public class INSS : Documento
    {
        public override string Tipo { get; protected set; } = "INSS";
        public string Numero { get; set; }

        public INSS(string numero, DateTime dataEmissao) : base(dataEmissao)
        {
            Numero = numero;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Número: {Numero}");
            Console.WriteLine($"Data de Emissão: {DataEmissao.ToShortDateString()}");
        }
    }

    public class Escola : Documento
    {
        public override string Tipo { get; protected set; } = "Escola";
        public string NomeDaEscola { get; set; }

        public Escola(string nomeDaEscola, DateTime dataEmissao) : base(dataEmissao)
        {
            NomeDaEscola = nomeDaEscola;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Nome da Escola: {NomeDaEscola}");
            Console.WriteLine($"Data de Conclusão: {DataEmissao.ToShortDateString()}");
        }
    }

    public class Obito : Documento
    {
        public override string Tipo { get; protected set; } = "Óbito";
        public DateTime DataObito { get; set; }

        public Obito(DateTime dataObito) : base(dataObito)
        {
            DataObito = dataObito;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Data de Óbito: {DataObito.ToShortDateString()}");
        }
    }
}
