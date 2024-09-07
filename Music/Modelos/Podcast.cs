namespace Music.Modelos;
class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string nome, string host)
    {
        Host = host;
        Nome = nome;

    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Podcast: {Nome} e Host: {Host}\n");

        foreach (Episodio episodio in episodios.OrderBy(a => a.Ordem))
        {
            Console.WriteLine($"Episódio {episodio.Ordem}: {episodio.Titulo}. Duração: {episodio.Duracao}. Resumo: {episodio.Resumo}");

        }


        Console.WriteLine($"\n\nNo total são: {TotalEpisodios} episódios.");
    }
}