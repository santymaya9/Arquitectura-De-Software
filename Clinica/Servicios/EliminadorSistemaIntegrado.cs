public class EliminadorSistemaIntegrado
{
    private IEliminar_cuenta eliminarCuenta;
    private IEliminar_CentroMedico eliminarCentroMedico;

    public EliminadorSistemaIntegrado(IEliminar_cuenta eliminarCuenta, IEliminar_CentroMedico eliminarCentroMedico)
    {
        this.eliminarCuenta = eliminarCuenta;
        this.eliminarCentroMedico = eliminarCentroMedico;
    }

    public void Eliminar_Cuenta(Cuenta cuenta, List<Cuenta> listaCuentas)
    {
        eliminarCuenta.Eliminar_cuenta(cuenta, listaCuentas);
    }

    public void Eliminar_CentroMedico(CentroMedico centroMedico, List<CentroMedico> listaCentros)
    {
        eliminarCentroMedico.Eliminar_CentroMedico(centroMedico, listaCentros);
    }
}
