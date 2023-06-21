Episodio ep1 = new(1, "Introdução ao canto popular", 50);
Episodio ep2 = new(2, "Orgão fonador", 30);

ep1.AdicionarConvidados("Karina, Manoel, Joaquim");
ep2.AdicionarConvidados("Maria");

Podcast podcast1 = new Podcast("Ana", "QAnto");
Podcast podcast2 = new Podcast("José", "É só testar...");

podcast1.AdicionarEpisodio(ep1);
podcast1.AdicionarEpisodio(ep2);

podcast1.ExibirDetalhes();
podcast2.ExibirDetalhes();