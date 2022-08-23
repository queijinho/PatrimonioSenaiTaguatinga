namespace PatrimonioSenaiTaguatinga.Entities;

public class Nivel{
    public Nivel(string nome)
    {
        Nome = nome;
    }

    public int IdNivel { get; set; }
    public string Nome { get; set; }
    public ICollection<Usuario> Usuarios { get; set; }= null!;


}