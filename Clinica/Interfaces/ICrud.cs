public interface ICrud
{
    void Agregar(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, string tipo_perfil);
    string Eliminar(Cuenta cuenta, Cuenta iniciada);
}
