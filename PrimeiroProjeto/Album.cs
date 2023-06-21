class Album
{
    private List<Musica> musicas = new List<Musica>();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public Genero Genero { get; set; }


    public void AdicionarMusica(Musica musica) => musicas.Add(musica);

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nEste album tem a duração de {DuracaoTotal} segundos");
    }
}