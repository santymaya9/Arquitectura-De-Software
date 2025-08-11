using System.Collections.Generic;

public class Paciente : Perfil
{
    private HistoriaClinica historiaClinica;
    private List<HistoriaClinica> historiasClinicas;

    public List<HistoriaClinica> HistoriasClinicas => historiasClinicas ?? new List<HistoriaClinica>();

    public Paciente(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, HistoriaClinica historiaClinica)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.historiaClinica = historiaClinica;
        historiasClinicas = new List<HistoriaClinica>();
    }

    public (float latitud, float longitud) Geolocalizar()
    {
        // Implementación de ejemplo
        return (0.0f, 0.0f);
    }

    public AlertaEmergencia Crear_Alerta((float latitud, float longitud) geolocalizar, Paciente paciente)
    {
        // Implementación de ejemplo
        return new AlertaEmergencia(
            "pendiente",
            paciente,
            geolocalizar.latitud,
            geolocalizar.longitud,
            System.DateTime.Now,
            System.DateTime.Now,
            null,
            null
        );
    }

    public override void Llamar(int telefono)
    {
        // Implementación específica de Paciente
    }

    public override void Trazar_ruta(AlertaEmergencia alerta, List<CentroMedico> centros_medicos)
    {
        // Implementación específica de Paciente
    }

    public override string Asignar_triaje(Paciente paciente, string nivel_triaje)
    {
        // Implementación específica de Paciente
        return "";
    }

    public override void Mostrar_alerta(AlertaEmergencia alerta_emergencia)
    {
        // Implementación específica de Paciente
    }

    public void PadecerAmbulancia(AmbulanciaEmergencia ambulancia) { }
    public void CrearAmbulanciaEmergencia(AmbulanciaEmergencia ambulancia) { }
    public void LlamarAmbulancia() { }
}
