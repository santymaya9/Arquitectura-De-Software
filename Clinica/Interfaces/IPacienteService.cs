public interface IPacienteService
{
    (float latitud, float longitud) Geolocalizar(Paciente paciente);
    AlertaEmergencia Crear_Alerta(Paciente paciente, (float latitud, float longitud) geolocalizar, Paciente pacienteAlerta);
    string Llamar(Paciente paciente, int telefono);
}
