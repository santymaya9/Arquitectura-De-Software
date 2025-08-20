using System;
using System.Collections.Generic;

public class ActualizarService : IActualizar_CentroMedico, IActualizar_Estado, IActualizar_Cuenta
{
    public void Actualizar_centroMedico(CentroMedico centroMedico, float latitud, float longitud, string nombre, string complejidad, int telefono)
    {
        // Lógica para actualizar un centro médico
        if (centroMedico != null)
        {
            centroMedico.Latitud = latitud;
            centroMedico.Longitud = longitud;
            centroMedico.Nombre = nombre;
            centroMedico.Complejidad = complejidad;
            centroMedico.Telefono = telefono;
        }
    }

    public string Actualizar_estado(AlertaEmergencia alerta, string estado)
    {
        // Lógica para actualizar el estado de una alerta
        if (alerta != null)
        {
            alerta.Estado = estado;
            return $"Estado de la alerta actualizado a {estado}";
        }
        return "No se pudo actualizar el estado";
    }

    public void Agregar(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, IRegistrar tipo_registro, TimeSpan fecha_creacion, bool estado_cuenta)
    {
        // Lógica para actualizar/agregar una cuenta
        string rol = tipo_registro.GetType().Name.Replace("Rol", "");
        var cuenta = new Cuenta(nombre, DateTime.Now, rol);
        cuenta.Perfil = nombre;
        cuenta.FechaCreacion = DateTime.Now;
        cuenta.Rol = rol;
        tipo_registro.Registrar(cuenta);
    }
}