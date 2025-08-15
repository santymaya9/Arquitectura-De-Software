using System;

public class RolParamedico : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // Asume que los datos específicos ya están en cuenta.Perfil
        cuenta.Rol = "Paramedico";
        cuenta.FechaCreacion = DateTime.Now;
        // Aquí podrías agregar validaciones o lógica específica si es necesario
    }
}
