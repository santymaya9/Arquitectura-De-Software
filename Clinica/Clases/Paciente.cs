using System.Collections.Generic;
using System;

public class Paciente : Perfil
{
    private HistoriaClinica historia_clinica;
    private float latitud;
    private float longitud;

    public HistoriaClinica HistoriaClinica => historia_clinica ?? null;
    public float Latitud => latitud;
    public float Longitud => longitud;

    public Paciente(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, HistoriaClinica historia_clinica, float latitud, float longitud)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.historia_clinica = historia_clinica;
        this.latitud = latitud;
        this.longitud = longitud;
    }

    public (float latitud, float longitud) Geolocalizar()
    {
        return (latitud, longitud);
    }

    public override void Llamar(int telefono)
    {
        // Implementación específica de Paciente
    }
}
