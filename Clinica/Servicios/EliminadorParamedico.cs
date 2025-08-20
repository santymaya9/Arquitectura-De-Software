public class EliminadorParamedico : IEliminar_alerta
{
    private readonly Paramedico _paramedico;
    public EliminadorParamedico(Paramedico paramedico)
    {
        _paramedico = paramedico;
    }
    public void Eliminar_alerta(AlertaEmergencia alerta, List<AlertaEmergencia> listaAlertas)
    {
        _paramedico?.AlertasAsignadas?.Remove(alerta);
    }
}
