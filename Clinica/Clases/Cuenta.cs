using System;
using System.Collections.Generic;

public class Cuenta
{
    private string perfil;
    private DateTime fecha_creacion;
    private string rol;
    

    public string Perfil => string.IsNullOrWhiteSpace(perfil) ? "Sin perfil" : perfil;
    public DateTime FechaCreacion => fecha_creacion == default ? DateTime.MinValue : fecha_creacion;
    public string Rol => string.IsNullOrWhiteSpace(rol) ? "Sin rol" : rol;
    

    public Cuenta(string perfil, DateTime fecha_creacion, string rol, List<string> permisos = null)
    {
        this.perfil = perfil;
        this.fecha_creacion = fecha_creacion;
        this.rol = rol;
      
    }
}
