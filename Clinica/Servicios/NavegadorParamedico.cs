using System.Collections.Generic;

public class NavegadorParamedico : IEnrutamiento
{
    public void Crear_ruta(AlertaEmergencia alerta, List<CentroMedico> l_centros_medicos, object G)
    {
        // L�gica para crear una ruta asociando la alerta con los centros m�dicos
        if (alerta != null && l_centros_medicos != null && l_centros_medicos.Count > 0)
        {
            alerta.Rutas = new Ruta(l_centros_medicos[0].Latitud, l_centros_medicos[0].Longitud, 1);
        }
    }

    public void Eliminar_ruta(AlertaEmergencia alerta)
    {
        // L�gica para eliminar la ruta asociada a la alerta
        if (alerta != null)
            alerta.Rutas = null;
    }
}
