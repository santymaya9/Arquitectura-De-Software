public class EliminadorSistemaIntegrado
{
    private IEliminar_cuenta eliminarCuenta;
    private IEliminar_CentroMedico eliminarCentroMedico;

    public EliminadorSistemaIntegrado(IEliminar_cuenta eliminarCuenta, IEliminar_CentroMedico eliminarCentroMedico)
    {
        this.eliminarCuenta = eliminarCuenta;
        this.eliminarCentroMedico = eliminarCentroMedico;
    }

    public void Eliminar_Cuenta(Cuenta cuenta, SistemaIntegrado sistema)
    {
        eliminarCuenta.Eliminar_cuenta(cuenta, sistema);
    }

    public void Eliminar_CentroMedico(CentroMedico centroMedico, SistemaIntegrado sistema)
    {
        eliminarCentroMedico.Eliminar_CentroMedico(centroMedico, sistema);
    }
}
