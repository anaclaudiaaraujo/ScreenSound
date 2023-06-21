class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duração)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duração = duração;
    }

    public int Ordem { get; }
    public string Titulo { get; }

    public int Duração { get;}
    public string Resumo => $"#{Ordem} - {Titulo} - ({Duração} min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}