Console.WriteLine("- - - - - Aula___Bandas - - - - -");
Banda queen = new Banda("Queen");
Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my Life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

Console.WriteLine("- - - - - Desafio___Podcasts - - - - -");

Host robert = new Host("Robert");
Podcast seteAlem = new Podcast(robert, "Setealem");

robert.AdicionarPodcast(seteAlem);

Episodios macarrao = new Episodios(1, "Macarrão", 200);
Episodios macarrao2 = new Episodios(2, "Macarrão2", 300);

seteAlem.AdicionarEpisodio(macarrao);
macarrao.AdicionarConvidados("João");
macarrao.AdicionarConvidados("Pedro");
macarrao.AdicionarConvidados("George");
seteAlem.AdicionarEpisodio(macarrao2);
macarrao2.AdicionarConvidados("Pedro");
macarrao2.AdicionarConvidados("Tarzan");

seteAlem.ExibirDetalhes();
robert.ExibirConteudo();