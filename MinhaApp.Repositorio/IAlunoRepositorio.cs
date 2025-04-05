using MinhaApp.Dominio;

namespace MinhaApp.Repositorio;

public interface IAlunoRepositorio
{
    void Salvar(Aluno aluno);
    IEnumerable<Aluno> Listar();
}
