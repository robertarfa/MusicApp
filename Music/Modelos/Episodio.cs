namespace Music.Modelos;
class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Duracao = duracao;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => //propriedade somente leitura/Lambda
       $"Episódio {Ordem} - {Titulo} - {Duracao}min - {string.Join(", ", convidados)}.";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}