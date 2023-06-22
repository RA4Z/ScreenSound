class Episodios
{
    public Episodios( int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Numero { get; set; }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public string DescricaoResumida => $"{Numero} - {Titulo} : {Duracao} | ";

    private List<string> convidados = new List<string>();

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}