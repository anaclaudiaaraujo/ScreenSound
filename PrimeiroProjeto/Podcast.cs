class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count();

    public void AdicionarEpisodio(Episodio episodio) => episodios.Add(episodio);

    public void ExibirDetalhes()
    {
        if (TotalEpisodios > 0)
        {
            Console.WriteLine($"\nPodcast {Nome} - apresentado por {Host}");
            foreach (Episodio episodio in episodios)
            {
                Console.WriteLine($"{episodio.Resumo}");
            }
            Console.WriteLine($"\nO podcast {Nome} tem {TotalEpisodios} episódio(s).");
        }
        else { Console.WriteLine($"\nO podcast {Nome} ainda não tem episódios."); }
    }
}