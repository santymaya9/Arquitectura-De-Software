public class VisualizadorSistemaIntegrado
{
    private IMostrar_Cuenta MostrarCuenta;
    private IMostrar_CentroMedico MostrarCentroMedico;

    public VisualizadorSistemaIntegrado(IMostrar_Cuenta mostrarCuenta, IMostrar_CentroMedico mostrarCentroMedico)
    {
        MostrarCuenta = mostrarCuenta;
        MostrarCentroMedico = mostrarCentroMedico;
    }

    public string Mostrar_CentroMedico(CentroMedico centro_medico)
        => MostrarCentroMedico.Mostrar(centro_medico);

    public string Mostrar_Cuenta(Cuenta cuenta)
        => MostrarCuenta.Mostrar(cuenta);
}
