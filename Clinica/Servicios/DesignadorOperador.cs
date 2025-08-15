using System;

public class DesignadorOperador : IAsignar_paramedico, INivel_triaje, IAsignar_alerta
{
    public string Asignar_triaje(AlertaEmergencia alerta, string nivel_triaje)
    {
        if (alerta != null && alerta.Paciente != null && alerta.Paciente.HistoriaClinica != null)
        {
            alerta.Paciente.HistoriaClinica.NivelTriaje = nivel_triaje;
            return $"Triaje '{nivel_triaje}' asignado a paciente {alerta.Paciente.Nombre}";
        }
        return "No se pudo asignar triaje";
    }

    public void Asignar_paramedico(Paramedico paramedico)
    {
        if (paramedico != null)
            paramedico.AlertasAsignadas.Add(new AlertaEmergencia("Asignada", null, 0, 0, DateTime.Now, DateTime.Now, null, paramedico));
    }

    public void Asignar_alerta(AlertaEmergencia alerta)
    {
        if (alerta != null && alerta.ParamedicoAsignado != null)
            alerta.ParamedicoAsignado.AlertasAsignadas.Add(alerta);
    }
}
