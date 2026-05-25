namespace proyecto.modelo;

public class Almacenador
{
    private List<Usuario> usuarios;

    public Almacenador()
    {
        usuarios = new List<Usuario>();
    }

    private bool ExisteUsuario(string nombre)
    {
        bool resultado = usuarios.Any(u=>u.getNombre()==nombre);
        return resultado;
    }
    public void AgregarUsuario(Usuario usuario)
    {
        
    }
}