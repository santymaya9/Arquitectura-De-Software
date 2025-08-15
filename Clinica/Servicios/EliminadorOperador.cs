public class EliminadorOperador
{
    private IEliminar_alerta eliminarAlerta;

    public EliminadorOperador(IEliminar_alerta eliminarAlerta)
    {
        this.eliminarAlerta = eliminarAlerta;
    }

    public void Eliminar_alerta(AlertaEmergencia alerta)
    {
        eliminarAlerta.Eliminar_alerta(alerta);
    }
}
