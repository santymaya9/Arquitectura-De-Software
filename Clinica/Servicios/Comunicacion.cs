public class Comunicacion : ILlamar
{
    public string Llamar(int telefono)
    {
        // Simula una llamada telef�nica
        return $"Llamando al n�mero {telefono}... Llamada realizada con �xito.";
    }
}
