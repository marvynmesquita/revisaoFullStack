namespace MinhaApp.Dominio;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Nota { get; set; }

    public Aluno(string nome, decimal nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public bool EstaAprovado() => Nota >= 7;
    
}
