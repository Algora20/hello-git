namespace proyecto.modelo;

public class Usuario
{
    private string nombre;
    private string contraseña;
    private int edad;
    private string informacion;

    public Usuario(string nombre, string contraseña)
    {
        this.nombre = nombre;
        this.contraseña = contraseña;
        edad = 0;
    }

    public int getEdad()
    {
        return edad;
    }

    public bool setEdad(int edad, out string mensaje)
    {
        mensaje = "";
        if (!int.TryParse(edad.ToString(), out edad))
        {
            mensaje="edad no valida";
            return false;
        }
        if (edad <= 0 || edad >= 120)
        {
            mensaje="edad no valida";
            return false;
        }
        mensaje="edad introducida correctamente";
        return true;
    }

    public string getNombre()
    {
        return nombre;
    }

    public string GetContrasena()
    {
        return contraseña;
    }

    public void IntroducirInformacion(string mensaje)
    {
        informacion = mensaje;
    }
    
    
    
}