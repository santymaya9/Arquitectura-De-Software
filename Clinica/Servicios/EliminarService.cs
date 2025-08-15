public class EliminarService : IEliminar_alerta
{
    public void Eliminar_alerta(AlertaEmergencia alerta)
    {
        if (alerta != null)
            alerta.Estado = "Eliminada";
    }
}
