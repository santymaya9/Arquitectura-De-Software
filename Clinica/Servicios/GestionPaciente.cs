public class GestionPaciente : IGestionPaciente
{
    public AlertaEmergencia crear_alerta(Paciente paciente, string latitud, string longitud)
    {
        // Lógica para crear una alerta de emergencia para el paciente
        return new AlertaEmergencia("Activa", paciente, float.Parse(latitud), float.Parse(longitud), DateTime.Now, DateTime.Now.AddHours(1), null, null);
    }
}
