public class Ruta
{
    private float latitud;
    private float longitud;
    private int num_nodo;

    public float Latitud => latitud;
    public float Longitud => longitud;
    public int NumNodo => num_nodo;

    public Ruta(float latitud, float longitud, int num_nodo)
    {
        this.latitud = latitud;
        this.longitud = longitud;
        this.num_nodo = num_nodo;
    }
}
