class Podcast
{
    public Podcast(Host host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Nome { get; }
    public Host Host { get; }
    public List<Episodios> episodios = new List<Episodios>();

    public void AdicionarEpisodio(Episodios ep)
    {
        episodios.Add(ep);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} - {Host.Nome}");
        foreach (var ep in episodios)
        {
            Console.WriteLine(ep.DescricaoResumida);
        }
        Console.WriteLine($"O total de episódios deste podcast é {episodios.Count()}");
    }

}