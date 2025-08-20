using System;
using System.Collections.Generic;

public class RegistroCuentas
{
    private IRegistrar _tipoRegistro;
    public IRegistrar TipoRegistro
    {
        get => _tipoRegistro;
        set => _tipoRegistro = value;
    }

    private ICrear_Cuenta _creacion;
    public ICrear_Cuenta Creacion
    {
        get => _creacion;
        set => _creacion = value;
    }

    public RegistroCuentas(IRegistrar tipoRegistro, ICrear_Cuenta creacion)
    {
        _tipoRegistro = tipoRegistro;
        _creacion = creacion;
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
        // La lógica de agregar a lista se maneja por la inyección de dependencia _creacion
        _creacion.Agregar(id, nombre, correo, celular, tipo_cedula, cedula, contrasena, tipo_registro, fecha_creacion, estado_cuenta);
    }
}
