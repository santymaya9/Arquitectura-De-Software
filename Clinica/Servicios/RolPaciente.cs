using System;

public class RolPaciente : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        cuenta.Rol = "Paciente";
        cuenta.FechaCreacion = DateTime.Now;
        // L�gica espec�fica para paciente si es necesario
    }
}
