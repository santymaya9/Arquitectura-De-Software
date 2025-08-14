using System;

public class CrudService : ICrud
{
    private readonly IRegistroSesion _registroSesion;

    public IRegistroSesion RegistroSesion => _registroSesion;

    public CrudService(IRegistroSesion registroSesion)
    {
        _registroSesion = registroSesion;
    }

    public void Agregar(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, string tipo_perfil)
    {
        // Lógica para agregar una cuenta
    }

    public string Eliminar(Cuenta cuenta, Cuenta iniciada)
    {
        // Lógica para eliminar una cuenta
        return "";
    }
}
