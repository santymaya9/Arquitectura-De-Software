using System;

public class VisualizadorSistemaIntegrado
{
    private IMostrar_Cuenta _mostrarCuenta;
    private IMostrar_CentroMedico _mostrarCentroMedico;

    public VisualizadorSistemaIntegrado(IMostrar_Cuenta mostrarCuenta, IMostrar_CentroMedico mostrarCentroMedico)
    {
        _mostrarCuenta = mostrarCuenta;
        _mostrarCentroMedico = mostrarCentroMedico;
    }

    // Accesores con get y set usando lambdas
    public IMostrar_Cuenta MostrarCuenta
    {
        get => _mostrarCuenta;
        set => _mostrarCuenta = value;
    }
    public IMostrar_CentroMedico MostrarCentroMedico
    {
        get => _mostrarCentroMedico;
        set => _mostrarCentroMedico = value;
    }

    // Métodos públicos
    public string Mostrar_CentroMedico(CentroMedico centro_medico)
        => _mostrarCentroMedico.Mostrar(centro_medico);

    public string Mostrar_Cuenta(Cuenta cuenta)
        => _mostrarCuenta.Mostrar(cuenta);
}
