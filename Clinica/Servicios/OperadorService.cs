using System;

public class OperadorService : IAsignar_paramedico, IEliminar_alerta, INivel_triaje
{
    public void Asignar_paramedico(Paramedico paramedico)
    {
        // L�gica para asignar param�dico
    }

    public void Eliminar_alerta(AlertaEmergencia alerta)
    {
        // L�gica para eliminar alerta
    }

    public string Asignar_triaje(AlertaEmergencia alerta, string nivel_triaje)
    {
        // L�gica para asignar triaje
        return "";
    }
}
