public class ParamedicoService : ICambiar_Estado, INivel_triaje, IRegistrar_Atencion
{
    public string Cambiar_estado(AlertaEmergencia alerta, string estado)
    {
        // L�gica para cambiar el estado de la alerta
        return "";
    }

    public string Registrar_Atencion(AlertaEmergencia alerta, int pulso, int nivel_conciencia, string observaciones)
    {
        // L�gica para registrar la atenci�n
        return "";
    }

    public string Asignar_triaje(AlertaEmergencia alerta, string nivel_triaje)
    {
        // L�gica para asignar triaje
        return "";
    }
}
