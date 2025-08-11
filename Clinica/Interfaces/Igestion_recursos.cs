public interface Igestion_recursos
{
    void Llamar(int telefono);
    void Trazar_ruta(AlertaEmergencia alerta, List<CentroMedico> centros_medicos);
    string Asignar_triaje(Paciente paciente, string nivel_triaje);
    void Mostrar_alerta(AlertaEmergencia alerta_emergencia);
}
