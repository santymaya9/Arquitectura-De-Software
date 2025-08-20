public class EliminarService : IEliminar_cuenta, IEliminar_CentroMedico
{
    public void Eliminar_cuenta(Cuenta cuenta, SistemaIntegrado sistema)
    {
        sistema?.Cuentas?.Remove(cuenta);
    }

    public void Eliminar_CentroMedico(CentroMedico centroMedico, SistemaIntegrado sistema)
    {
        sistema?.CentroMedico?.Remove(centroMedico);
    }
}
