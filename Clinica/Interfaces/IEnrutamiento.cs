using System.Collections.Generic;

public interface IEnrutamiento
{
    void Crear_ruta(AlertaEmergencia alerta, List<CentroMedico> l_centros_medicos);
    void Eliminar_ruta(AlertaEmergencia alerta, List<Ruta> listaRutas);
}
