public class NavegadorPaciente
{
    private IGeolocalizacion _geolocalizacion;
    public IGeolocalizacion Geolocalizacion
    {
        get => _geolocalizacion;
        set => _geolocalizacion = value;
    }

    public NavegadorPaciente(IGeolocalizacion geolocalizacion)
    {
        Geolocalizacion = geolocalizacion;
    }

    public (float latitud, float longitud) Ubicacion(Paciente paciente)
    {
        return Geolocalizacion.Ubicacion(paciente);
    }
}
