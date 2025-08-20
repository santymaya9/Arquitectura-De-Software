public interface ICrear_Cuenta
{
    void Agregar(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, IRegistrar tipo_registro, TimeSpan fecha_creacion, bool estado_cuenta);
}
