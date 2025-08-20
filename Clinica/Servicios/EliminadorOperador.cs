public class EliminadorOperador : IEliminar_alerta
{
    private readonly Operador _operador;
    public EliminadorOperador(Operador operador)
    {
        _operador = operador;
    }
    public void Eliminar_alerta(AlertaEmergencia alerta, List<AlertaEmergencia> listaAlertas)
    {
        _operador?.AlertasEmergencia?.Remove(alerta);
    }
}
