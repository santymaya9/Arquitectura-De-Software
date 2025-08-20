using System;

public class RolParamedico : IRegistroSesion, IRegistrar
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        cuenta.Rol = "Paramedico";
        cuenta.FechaCreacion = DateTime.Now;
    }

    public void Registrar(Cuenta cuenta)
    {
        RegistrarSesion(cuenta);
    }
}
