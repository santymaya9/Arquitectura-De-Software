public interface IGestion_paciente
{
    (string latitud, string longitud) Ubicacion(Paciente paciente);
    AlertaEmergencia crear_alerta(Paciente paciente, string latitud, string longitud);
}
