namespace Music.Modelos;
class Playlist
{
    private List<Musica> musicas = new List<Musica>();

    public Playlist(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarMusicasPlaylist(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasPlaylist()
    {
        Console.WriteLine($"Músicas da Playlist:");

        for (int i = 0; i < musicas.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {musicas[i].Nome}");
        }
    }
}