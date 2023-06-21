using PrimeiroProjeto;

Banda halestorm = new Banda("Halestorm");
Album albumHalestorm = new Album("The strange case of");

Musica musica1 = new Musica(halestorm, "I miss the misery");
musica1.Duracao = 312;

Musica musica2 = new Musica(halestorm, "Love bites")
{
    Duracao = 300,
    Disponivel = true,
};

Musica musica3 = new Musica(halestorm, "Beautiful with you");
Musica musica4 = new Musica(halestorm, "Break in");
Musica musica5 = new Musica(halestorm, "Here's to Us");


albumHalestorm.AdicionarMusica(musica1);
albumHalestorm.AdicionarMusica(musica2);
halestorm.AdicionarAlbum(albumHalestorm);
albumHalestorm.ExibirMusicasAlbum();

halestorm.ExibirDiscografia();
