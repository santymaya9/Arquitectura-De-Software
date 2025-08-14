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
        // L�gica para cerrar sesi�n
    }

    public void Iniciar_sesion(Cuenta cuenta)
    {
        // L�gica para iniciar sesi�n
        _registroSesion.RegistrarSesion(cuenta);
    }
}
