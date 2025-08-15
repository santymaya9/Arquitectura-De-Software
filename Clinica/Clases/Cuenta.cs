using System;
using System.Collections.Generic;

public class Cuenta
{
    private string perfil;
    private DateTime fecha_creacion;
    private string rol;

    public string Perfil
    {
        get => string.IsNullOrWhiteSpace(perfil) ? "Sin perfil" : perfil;
        set => perfil = value;
    }
    public DateTime FechaCreacion
    {
        get => fecha_creacion == default ? DateTime.MinValue : fecha_creacion;
        set => fecha_creacion = value;
    }
    public string Rol
    {
        get => string.IsNullOrWhiteSpace(rol) ? "Sin rol" : rol;
        set => rol = value;
    }

    public Cuenta(string perfil, DateTime fecha_creacion, string rol)
    {
        this.perfil = perfil;
        this.fecha_creacion = fecha_creacion;
        this.rol = rol;
    }
}
