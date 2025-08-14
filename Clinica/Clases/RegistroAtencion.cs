using System;

public class RegistroAtencion
{
    private AlertaEmergencia alerta;
    private int pulso;
    private int nivel_conciencia;
    private string observaciones;
    private DateTime fecha;

    public AlertaEmergencia Alerta => alerta ?? null;
    public int Pulso => pulso;
    public int NivelConciencia => nivel_conciencia;
    public string Observaciones => string.IsNullOrWhiteSpace(observaciones) ? "Sin observaciones" : observaciones;
    public DateTime Fecha => fecha == default ? DateTime.MinValue : fecha;

    public RegistroAtencion(AlertaEmergencia alerta, int pulso, int nivel_conciencia, string observaciones, DateTime fecha)
    {
        this.alerta = alerta;
        this.pulso = pulso;
        this.nivel_conciencia = nivel_conciencia;
        this.observaciones = observaciones;
        this.fecha = fecha;
    }
}
