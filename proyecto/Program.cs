using proyecto.modelo;

namespace proyecto;

class Program
{
    static void Main(string[] args)
    {
        List<Usuario> listaUsuario = new List<Usuario>();
        listaUsuario.Add(new Usuario("Jose", "1234"));
        listaUsuario.Add(new Usuario("Maria", "1234"));

        do
        {
            bool existe = false;
            Console.WriteLine("Ingrese el nombre del usuario: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña del usuario: ");
            string contrasena = Console.ReadLine();
            foreach (Usuario u in listaUsuario)
            {
                if (u.getNombre().Equals(nombre))
                {
                    Console.WriteLine("El usuario con el nombre es " + nombre);
                    if (u.GetContrasena() == contrasena)
                    {
                        Console.WriteLine("Existe usuario y la contraseña es correcta.");
                        existe = true;
                    }
                    else
                    {
                        Console.WriteLine("Existe usuario pero la contraseña es incorrecta.");
                    }
                    break;
                }
                Console.WriteLine("No existe usuario");
                break;
                
            }

            if (existe)
            {
                Usuario u = new Usuario(nombre, contrasena);
                Console.WriteLine($"{u.getNombre()}, {u.GetContrasena()}");
                
                
            }
        } while (true);
    }
}