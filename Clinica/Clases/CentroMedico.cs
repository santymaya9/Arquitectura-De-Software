public class CentroMedico
{
    private string nombre;
    private float latitud;
    private float longitud;
    private string complejidad;
    private int telefono;

    public string Nombre => string.IsNullOrWhiteSpace(nombre) ? "Sin nombre" : nombre;
    public float Latitud => latitud;
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
