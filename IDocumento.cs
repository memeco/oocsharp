namespace Documentos
{
    public interface IDocumento
    {
        string Tipo { get; }
        DateTime DataEmissao { get; }
        void ExibirDetalhes();
    }
}
