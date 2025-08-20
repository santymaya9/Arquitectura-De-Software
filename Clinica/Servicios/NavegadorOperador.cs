using System.Collections.Generic;

public class NavegadorOperador : IEnrutamiento
{
    public void Crear_ruta(AlertaEmergencia alerta, List<CentroMedico> l_centros_medicos)
    {
        // Lógica para crear una ruta asociando la alerta con los centros médicos
        if (alerta != null && l_centros_medicos != null && l_centros_medicos.Count > 0)
        {
            alerta.Rutas = new Ruta(l_centros_medicos[0].Latitud, l_centros_medicos[0].Longitud, 1);
        }
    }

    public void Eliminar_ruta(AlertaEmergencia alerta, List<Ruta> listaRutas)
    {
        // Elimina la ruta de la lista de rutas si existe
        if (alerta != null && alerta.Rutas != null && listaRutas != null)
        {
            listaRutas.Remove(alerta.Rutas);
            alerta.Rutas = null;
        }
    }
}
