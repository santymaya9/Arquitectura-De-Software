public class GestionCentroMedico : ICrear_CentroMedico, IActualizar_CentroMedico
{
    public void Crear_centroMedico(float latitud, float longitud, string nombre, string complejidad, int telefono)
    {
        // Lógica para crear un centro médico
        var centroMedico = new CentroMedico(nombre, latitud, longitud, complejidad, telefono);
        // Aquí podrías agregar el centro médico a una lista o base de datos si es necesario
    }

    public void Actualizar_centroMedico(CentroMedico centroMedico, float latitud, float longitud, string nombre, string complejidad, int telefono)
    {
        // Lógica para actualizar un centro médico
        if (centroMedico != null)
        {
            centroMedico.Latitud = latitud;
            centroMedico.Longitud = longitud;
            centroMedico.Nombre = nombre;
            centroMedico.Complejidad = complejidad;
            centroMedico.Telefono = telefono;
        }
    }
}
