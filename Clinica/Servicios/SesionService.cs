using System;

public class SesionService : ISesion
{
    private readonly IRegistroSesion _registroSesion;

    public SesionService(IRegistroSesion registroSesion)
    {
        _registroSesion = registroSesion;
    }

    public void Cerrar_sesion(Cuenta cuenta)
    {
        // Lógica para cerrar sesión
    }

    public void Iniciar_sesion(Cuenta cuenta)
    {
        // Lógica para iniciar sesión
        _registroSesion.RegistrarSesion(cuenta);
    }
}
