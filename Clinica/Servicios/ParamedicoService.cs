public class ParamedicoService : ICambiar_Estado, INivel_triaje, IRegistrar_Atencion
{
    public string Cambiar_estado(AlertaEmergencia alerta, string estado)
    {
        // Lógica para cambiar el estado de la alerta
        return "";
    }

    public string Registrar_Atencion(AlertaEmergencia alerta, int pulso, int nivel_conciencia, string observaciones)
    {
        // Lógica para registrar la atención
        return "";
    }

    public string Asignar_triaje(AlertaEmergencia alerta, string nivel_triaje)
    {
        // Lógica para asignar triaje
        return "";
    }
}
