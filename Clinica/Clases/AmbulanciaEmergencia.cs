using System;

public class AmbulanciaEmergencia
{
    private string estado;
    private Paciente paciente;
    private float latitud;
    private float longitud;
    private DateTime fecha;
    private Ruta ruta;
    private Paramedico paramedico;

    public string Estado => string.IsNullOrWhiteSpace(estado) ? "Sin estado" : estado;
    public Paciente Paciente => paciente;
    public float Latitud => latitud;
    public float Longitud => longitud;
    public DateTime Fecha => fecha;
    public Ruta Ruta => ruta;
    public Paramedico Paramedico => paramedico;

    public AmbulanciaEmergencia(string estado, Paciente paciente, float latitud, float longitud, DateTime fecha, Ruta ruta, Paramedico paramedico)
    {
        this.estado = estado;
        this.paciente = paciente;
        this.latitud = latitud;
        this.longitud = longitud;
        this.fecha = fecha;
        this.ruta = ruta;
        this.paramedico = paramedico;
    }
}
