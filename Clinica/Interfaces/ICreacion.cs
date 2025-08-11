public interface ICreacion
{
    void Agregar(uint id, string nombre, string correo, string celular, int tipo_cedula, string cedula, int contrasena, string tipo_perfil);
    void Leer(Cuenta cuenta);
    string Eliminar(Cuenta cuenta, Cuenta iniciada);
}
