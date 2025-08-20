public class VisualizadorAlerta
{
    private IMostrar_Alerta _mostrarAlerta;

    public VisualizadorAlerta(IMostrar_Alerta mostrarAlerta)
    {
        _mostrarAlerta = mostrarAlerta;
    }

    public string Mostrar_alerta(AlertaEmergencia alerta)
    {
        return _mostrarAlerta.Mostrar(alerta);
    }
}
