class Host
{
    public Host(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    private List<Podcast> podcasts = new List<Podcast>();

    public void AdicionarPodcast(Podcast podcast)
    {
        podcasts.Add(podcast);
    }

    public void ExibirConteudo()
    {
        Console.WriteLine($"Listagem do conteúdo do criador {Nome}:");
        foreach( Podcast podcast in podcasts )
        {
            Console.WriteLine(podcast.Nome);
        }
    }
}