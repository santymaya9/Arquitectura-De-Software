public class Comunicacion : ILlamar
{
    public string Llamar(int telefono)
    {
        // Simula una llamada telefónica
        return $"Llamando al número {telefono}... Llamada realizada con éxito.";
    }
}
