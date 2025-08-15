using System;

public class CrudService : ICrud
{
    public void Agregar(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, IRegistrar tipo_registro)
    {
        var cuenta = new Cuenta(nombre, DateTime.Now, "");
        cuenta.Correo = correo;
        cuenta.Celular = celular;
        cuenta.TipoCedula = tipo_cedula;
        cuenta.Cedula = cedula;
        cuenta.Contrasena = contrasena;
        cuenta.Id = id;
        tipo_registro.Registrar(cuenta);
    }
}
