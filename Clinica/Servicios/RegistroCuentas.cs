public class RegistroCuentas
{
    private IRegistrar _tipoRegistro;
    public IRegistrar TipoRegistro
    {
        get => _tipoRegistro;
        set => _tipoRegistro = value;
    }

    private SistemaIntegrado _sistemaIntegrado;
    public RegistroCuentas(SistemaIntegrado sistemaIntegrado)
    {
        _sistemaIntegrado = sistemaIntegrado;
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
        _sistemaIntegrado.Cuentas.Add(cuenta);
    }
}
