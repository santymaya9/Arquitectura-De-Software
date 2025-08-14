using System.Collections.Generic;

public interface IEnrutamiento
{
    void Crear_ruta(AlertaEmergencia alerta, List<CentroMedico> l_centros_medicos, object G);
    void Eliminar_ruta(AlertaEmergencia alerta);
}
