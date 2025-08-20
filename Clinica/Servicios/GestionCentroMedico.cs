public class GestionCentroMedico : ICrear_CentroMedico, IActualizar_CentroMedico
{
    public void Crear_centroMedico(float latitud, float longitud, string nombre, string complejidad, int telefono)
    {
        // L�gica para crear un centro m�dico
        var centroMedico = new CentroMedico(nombre, latitud, longitud, complejidad, telefono);
        // Aqu� podr�as agregar el centro m�dico a una lista o base de datos si es necesario
    }

    public void Actualizar_centroMedico(CentroMedico centroMedico, float latitud, float longitud, string nombre, string complejidad, int telefono)
    {
        // L�gica para actualizar un centro m�dico
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
