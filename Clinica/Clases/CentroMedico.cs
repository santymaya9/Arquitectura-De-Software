public class CentroMedico
{
    private float latitud;
    private string nombre;
    private float longitud;
    private string complejidad;
    private int telefono;

    public float Latitud => latitud;
    public string Nombre => nombre;
    public float Longitud => longitud;
    public string Complejidad => complejidad;
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
