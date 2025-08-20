public class CrearService : ICrear_CentroMedico, ICrear_Alerta, ICrear_Cuenta
{
    public void Crear_centroMedico(float latitud, float longitud, string nombre, string complejidad, int telefono)
    {
        // Lógica para crear un centro médico
        var centroMedico = new CentroMedico(nombre, latitud, longitud, complejidad, telefono);
        // Aquí podrías agregar el centro médico a una lista o base de datos si es necesario
    }

    public AlertaEmergencia crear_alerta(Paciente paciente, string latitud, string longitud)
    {
        // Lógica para crear una alerta de emergencia
        return new AlertaEmergencia("Activa", paciente, float.Parse(latitud), float.Parse(longitud), DateTime.Now, DateTime.Now.AddHours(1), null, null);
    }

    public void Agregar(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, IRegistrar tipo_registro, TimeSpan fecha_creacion, bool estado_cuenta)
    {
        // El rol se obtiene del tipo de registro
        string rol = tipo_registro.GetType().Name.Replace("Rol", "");
        var cuenta = new Cuenta(nombre, DateTime.Now, rol);
        cuenta.Perfil = nombre;
        cuenta.FechaCreacion = DateTime.Now;
        cuenta.Rol = rol;
        tipo_registro.Registrar(cuenta);
        // Aquí podrías agregar la cuenta a una lista o base de datos si es necesario
    }
}
