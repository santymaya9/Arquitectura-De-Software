using System;

public class RolParamedico : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        cuenta.Rol = "Paramedico";
        cuenta.FechaCreacion = DateTime.Now;
        // L�gica espec�fica para param�dico si es necesario
    }
}
