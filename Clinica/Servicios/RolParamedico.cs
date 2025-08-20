using System;

public class RolParamedico : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        cuenta.Rol = "Paramedico";
        cuenta.FechaCreacion = DateTime.Now;
        // Lógica específica para paramédico si es necesario
    }
}
