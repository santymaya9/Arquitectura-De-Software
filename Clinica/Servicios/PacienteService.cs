public class PacienteService : IGestion_paciente
{
    public (string latitud, string longitud) Ubicacion(Paciente paciente)
    {
        // Devuelve la latitud y longitud del paciente
        return (paciente?.Latitud.ToString() ?? "0", paciente?.Longitud.ToString() ?? "0");
    }

    public AlertaEmergencia crear_alerta(Paciente paciente, string latitud, string longitud)
    {
        // Crea una alerta de emergencia para el paciente
        return new AlertaEmergencia("Activa", paciente, float.Parse(latitud), float.Parse(longitud), DateTime.Now, DateTime.Now.AddHours(1), null, null);
    }
}
