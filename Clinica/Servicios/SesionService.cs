using System;

public class SesionService : ISesion
{
    public void Cerrar_sesion(Cuenta cuenta)
    {
        // Marca la cuenta como cerrada (ejemplo)
        if (cuenta != null)
            cuenta.Perfil = $"{cuenta.Perfil} (Sesi�n cerrada)";
    }

    public void Iniciar_sesion(Cuenta cuenta)
    {
        // Marca la cuenta como activa (ejemplo)
        if (cuenta != null)
            cuenta.Perfil = $"{cuenta.Perfil} (Sesi�n iniciada)";
    }
}
