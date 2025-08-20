public class EliminarService : IEliminar_cuenta, IEliminar_CentroMedico, IEliminar_alerta
{
    public void Eliminar_cuenta(Cuenta cuenta, List<Cuenta> listaCuentas)
    {
        listaCuentas?.Remove(cuenta);
    }

    public void Eliminar_CentroMedico(CentroMedico centroMedico, List<CentroMedico> listaCentros)
    {
        listaCentros?.Remove(centroMedico);
    }

    public void Eliminar_alerta(AlertaEmergencia alerta, List<AlertaEmergencia> listaAlertas)
    {
        if (alerta != null && listaAlertas != null)
        {
            listaAlertas.Remove(alerta);
        }
    }
}
