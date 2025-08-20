public class EliminarAlertaOperador : IEliminar_alerta
{
    private readonly Operador _operador;
    public EliminarAlertaOperador(Operador operador)
    {
        _operador = operador;
    }
    public void Eliminar_alerta(AlertaEmergencia alerta)
    {
        _operador?.AlertasEmergencia?.Remove(alerta);
    }
}
