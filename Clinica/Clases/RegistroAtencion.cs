using System;

public class RegistroAtencion
{
    private AlertaEmergencia alerta;
    private int pulso;
    private int nivel_conciencia;
    private string observaciones;
    private DateTime fecha;

    public AlertaEmergencia Alerta
    {
        get => alerta;
        set => alerta = value;
    }
    public int Pulso
    {
        get => pulso;
        set => pulso = value;
    }
    public int NivelConciencia
    {
        get => nivel_conciencia;
        set => nivel_conciencia = value;
    }
    public string Observaciones
    {
        get => string.IsNullOrWhiteSpace(observaciones) ? "Sin observaciones" : observaciones;
        set => observaciones = value;
    }
    public DateTime Fecha
    {
        get => fecha == default ? DateTime.MinValue : fecha;
        set => fecha = value;
    }

    public RegistroAtencion(AlertaEmergencia alerta, int pulso, int nivel_conciencia, string observaciones, DateTime fecha)
    {
        this.alerta = alerta;
        this.pulso = pulso;
        this.nivel_conciencia = nivel_conciencia;
        this.observaciones = observaciones;
        this.fecha = fecha;
    }
}
