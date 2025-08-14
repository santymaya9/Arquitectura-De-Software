public class PacienteService : IGestion_paciente
{
    public (string latitud, string longitud) Ubicacion()
    {
        // Lógica para obtener la ubicación
        return ("", "");
    }

    public AlertaEmergencia crear_alerta(Paciente paciente, string latitud, string longitud)
    {
        // Lógica para crear una alerta
        return null;
    }
}
