using System;
using System.Collections.Generic;
using Documentos;

namespace CadastroPessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<IDocumento> Documentos { get; set; }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Documentos = new List<IDocumento>();
        }

        public void AdicionarDocumento(IDocumento documento)
        {
            Documentos.Add(documento);
        }
    }
}
