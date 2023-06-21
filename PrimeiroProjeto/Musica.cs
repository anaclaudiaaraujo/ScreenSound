namespace PrimeiroProjeto
{
    public class Musica
    {
        public Musica(Banda artista, string nome)
        {
            Nome = nome;
            Artista = artista;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public Album Album { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista.Nome}.";

        
        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"{Artista.Nome} - {Nome} - {Album.Nome} - {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plus.");
            }
        }
    }
}
