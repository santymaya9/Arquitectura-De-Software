public class MostrarService : IMostrar_CentroMedico, IMostrar_Cuenta, IMostrar_Alerta
{
    public string Mostrar(CentroMedico centro_medico)
    {
        return $"Centro Médico: {centro_medico?.Nombre ?? "Desconocido"}, " +
               $"Latitud: {centro_medico?.Latitud}, Longitud: {centro_medico?.Longitud}, " +
               $"Complejidad: {centro_medico?.Complejidad ?? "Sin complejidad"}, " +
               $"Teléfono: {centro_medico?.Telefono}";
    }

    public string Mostrar(Cuenta cuenta)
    {
        return $"Cuenta: Perfil={cuenta?.Perfil ?? "Desconocido"}, " +
               $"Rol={cuenta?.Rol ?? "Desconocido"}, " +
               $"Fecha de creación={cuenta?.FechaCreacion.ToString("yyyy-MM-dd") ?? "Sin fecha"}";
    }

    public string Mostrar(AlertaEmergencia alerta)
    {
        return $"Alerta: Estado={alerta?.Estado ?? "Sin estado"}, " +
               $"Paciente={alerta?.Paciente?.Nombre ?? "Sin paciente"}, " +
               $"Latitud={alerta?.Latitud}, Longitud={alerta?.Longitud}, " +
               $"Fecha={alerta?.Fecha.ToString("yyyy-MM-dd HH:mm") ?? "Sin fecha"}";
    }
}
