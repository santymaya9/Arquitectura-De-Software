public interface IGestion_paciente
{
    (string latitud, string longitud) Ubicacion();
    AlertaEmergencia crear_alerta(Paciente paciente, string latitud, string longitud);
}
