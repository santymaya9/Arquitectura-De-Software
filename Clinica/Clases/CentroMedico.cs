public class CentroMedico
{
    private float latitud;
    private string nombre;
    private float longitud;
    private string complejidad;
    private int telefono;

    public float Latitud => latitud;
    public string Nombre => string.IsNullOrWhiteSpace(nombre) ? "Sin nombre" : nombre;
    public float Longitud => longitud;
    public string Complejidad => string.IsNullOrWhiteSpace(complejidad) ? "Sin complejidad" : complejidad;
    public int Telefono => telefono;

    public CentroMedico(string nombre, float latitud, float longitud, string complejidad, int telefono)
    {
        this.nombre = nombre;
        this.latitud = latitud;
        this.longitud = longitud;
        this.complejidad = complejidad;
        this.telefono = telefono;
    }
}
