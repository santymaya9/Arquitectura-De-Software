using System;
using System.Collections.Generic;

public class ActualizadorSistemaIntegrado
{
    private IActualizar_Cuenta _actualizarCuenta;
    public IActualizar_Cuenta ActualizarCuenta
    {
        get => _actualizarCuenta;
        set => _actualizarCuenta = value;
    }

    public ActualizadorSistemaIntegrado(IActualizar_Cuenta actualizarCuenta)
    {
        _actualizarCuenta = actualizarCuenta;
    }

    public void Actualizar_Cuenta(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, IRegistrar tipo_registro, TimeSpan fecha_creacion, bool estado_cuenta)
    {
        _actualizarCuenta.Agregar(id, nombre, correo, celular, tipo_cedula, cedula, contrasena, tipo_registro, fecha_creacion, estado_cuenta);
    }
}