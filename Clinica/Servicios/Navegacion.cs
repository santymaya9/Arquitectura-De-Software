using System.Collections.Generic;

public class Navegacion : IGeolocalizacion, IEnrutamiento
{
    public void Crear_ruta(AlertaEmergencia alerta, List<CentroMedico> l_centros_medicos)
    {
        if (alerta != null && l_centros_medicos != null && l_centros_medicos.Count > 0)
        {
            alerta.Rutas = new Ruta(l_centros_medicos[0].Latitud, l_centros_medicos[0].Longitud, 1);
        }
    }

    public void Eliminar_ruta(AlertaEmergencia alerta, List<Ruta> listaRutas)
    {
        if (alerta != null && alerta.Rutas != null && listaRutas != null)
        {
            listaRutas.Remove(alerta.Rutas);
            alerta.Rutas = null;
        }
    }

    public (float latitud, float longitud) Ubicacion(Paciente paciente)
    {
        return (paciente?.Latitud ?? 0, paciente?.Longitud ?? 0);
    }
}
