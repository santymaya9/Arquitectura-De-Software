using System;

public class RolPaciente : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // Asume que los datos espec�ficos ya est�n en cuenta.Perfil
        cuenta.Rol = "Paciente";
        cuenta.FechaCreacion = DateTime.Now;
        // Aqu� podr�as agregar validaciones o l�gica espec�fica si es necesario
    }
}
