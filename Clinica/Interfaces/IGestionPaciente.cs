public interface IGestionPaciente
{
    AlertaEmergencia crear_alerta(Paciente paciente, string latitud, string longitud);
}
