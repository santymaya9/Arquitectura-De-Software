public class AlertaEmergencia
{
    private string estado;
    private Paciente paciente;
    private float latitud;
    private float longitud;
    private DateTime fecha;
    private DateTime fecha_finalizacion;
    private Ruta rutas;
    private Paramedico paramedicoAsignado;

    public string Estado => string.IsNullOrWhiteSpace(estado) ? "Sin estado" : estado;
    public Paciente Paciente => paciente ?? null;
    public float Latitud => latitud;
    public float Longitud => longitud;
    public DateTime Fecha => fecha == default ? DateTime.MinValue : fecha;
    public DateTime FechaFinalizacion => fecha_finalizacion == default ? DateTime.MinValue : fecha_finalizacion;
    public Ruta Rutas => rutas ?? null;
    public Paramedico ParamedicoAsignado => paramedicoAsignado ?? null;
  
    public AlertaEmergencia(string estado, Paciente paciente, float latitud, float longitud, DateTime fecha, DateTime fecha_finalizacion, Ruta rutas, Paramedico paramedicoAsignado)
    {
        this.estado = estado;
        this.paciente = paciente;
        this.latitud = latitud;
        this.longitud = longitud;
        this.fecha = fecha;
        this.fecha_finalizacion = fecha_finalizacion;
        this.rutas = rutas;
        this.paramedicoAsignado = paramedicoAsignado;
    }
}
