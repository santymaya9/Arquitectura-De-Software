using System;

public class OperadorService : IAsignar_paramedico, IEliminar_alerta, INivel_triaje
{
    public void Asignar_paramedico(Paramedico paramedico)
    {
        // Lógica para asignar paramédico
    }

    public void Eliminar_alerta(AlertaEmergencia alerta)
    {
        // Lógica para eliminar alerta
    }

    public string Asignar_triaje(AlertaEmergencia alerta, string nivel_triaje)
    {
        // Lógica para asignar triaje
        return "";
    }
}
