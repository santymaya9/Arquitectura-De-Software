using System;
using System.Collections.Generic;

public class ActualizarCuentas
{
    private IActualizar_Cuenta _actualizacion;
    public IActualizar_Cuenta Actualizacion
    {
        get => _actualizacion;
        set => _actualizacion = value;
    }

    public ActualizarCuentas(IActualizar_Cuenta actualizacion)
    {
        _actualizacion = actualizacion;
    }

    public void Agregar(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, IRegistrar tipo_registro, TimeSpan fecha_creacion, bool estado_cuenta)
    {
        _actualizacion.Agregar(id, nombre, correo, celular, tipo_cedula, cedula, contrasena, tipo_registro, fecha_creacion, estado_cuenta);
    }
}