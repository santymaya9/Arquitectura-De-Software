using System;

public class RolPaciente : IRegistroSesion, IRegistrar
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        cuenta.Rol = "Paciente";
        cuenta.FechaCreacion = DateTime.Now;
    }

    public void Registrar(Cuenta cuenta)
    {
        RegistrarSesion(cuenta);
    }
}
