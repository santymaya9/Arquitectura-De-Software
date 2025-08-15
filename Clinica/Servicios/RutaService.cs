using System.Collections.Generic;

public class RutaService : IEnrutamiento
{
    public void Crear_ruta(AlertaEmergencia alerta, List<CentroMedico> l_centros_medicos, object G)
    {
        // Crea una ruta asociando la alerta con los centros médicos (ejemplo)
        if (alerta != null && l_centros_medicos != null && l_centros_medicos.Count > 0)
        {
            alerta.Rutas = new Ruta(l_centros_medicos[0].Latitud, l_centros_medicos[0].Longitud, 1);
        }
    }

    public void Eliminar_ruta(AlertaEmergencia alerta)
    {
        // Elimina la ruta asociada a la alerta (ejemplo)
        if (alerta != null)
            alerta.Rutas = null;
    }
}
