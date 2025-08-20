public class EliminarAlertaParamedico : IEliminar_alerta
{
    private readonly Paramedico _paramedico;
    public EliminarAlertaParamedico(Paramedico paramedico)
    {
        _paramedico = paramedico;
    }
    public void Eliminar_alerta(AlertaEmergencia alerta)
    {
        _paramedico?.AlertasAsignadas?.Remove(alerta);
    }
}
