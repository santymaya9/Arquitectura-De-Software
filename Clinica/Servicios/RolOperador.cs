using System;

public class RolOperador : IRegistroSesion, IRegistrar
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // Asume que los datos espec�ficos ya est�n en cuenta.Perfil
        cuenta.Rol = "Operador";
        cuenta.FechaCreacion = DateTime.Now;
        // Aqu� podr�as agregar validaciones o l�gica espec�fica si es necesario
    }

    public void Registrar(Cuenta cuenta)
    {
        RegistrarSesion(cuenta);
    }
}
