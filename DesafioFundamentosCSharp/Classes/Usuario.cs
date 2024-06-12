namespace DesafioFundamentosCSharp.Classes;
internal class Usuario
{
    public string Nome { get; set; }
    public string SobreNome { get; set; }

    public Usuario(string nome, string sobreNome)
    {
        Nome = nome;
        SobreNome = sobreNome;
    }

    public string ObterMensagemBoasVindas()
    {
        return $"Olá, {Nome}! Seja muito bem-vindo!";
    }

    public string ConcatenarNomes()
    {
        return Nome.Trim() + " " + SobreNome.Trim();
    }
}