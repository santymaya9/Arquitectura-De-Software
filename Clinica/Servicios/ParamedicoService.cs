public class ParamedicoService : ICambiar_Estado, INivel_triaje, IRegistrar_Atencion
{
    public string Cambiar_estado(AlertaEmergencia alerta, string estado)
    {
        // Cambia el estado de la alerta
        if (alerta != null)
        {
            alerta.Estado = estado;
            return $"Estado de la alerta cambiado a {estado}";
        }
        return "No se pudo cambiar el estado";
    }

    public string Registrar_Atencion(AlertaEmergencia alerta, int pulso, int nivel_conciencia, string observaciones)
    {
        // Registra la atención médica en la alerta
        if (alerta != null && alerta.ParamedicoAsignado != null)
        {
            var registro = new RegistroAtencion(alerta, pulso, nivel_conciencia, observaciones, DateTime.Now);
            alerta.ParamedicoAsignado.RegistroAtenciones.Add(registro);
            return $"Atención registrada para alerta de paciente {alerta.Paciente?.Nombre ?? "Desconocido"}";
        }
        return "No se pudo registrar la atención";
    }

    public string Asignar_triaje(AlertaEmergencia alerta, string nivel_triaje)
    {
        // Asigna un nivel de triaje a la historia clínica del paciente
        if (alerta != null && alerta.Paciente != null && alerta.Paciente.HistoriaClinica != null)
        {
            alerta.Paciente.HistoriaClinica.NivelTriaje = nivel_triaje;
            return $"Triaje '{nivel_triaje}' asignado a paciente {alerta.Paciente.Nombre}";
        }
        return "No se pudo asignar triaje";
    }
}
