using System.Collections.Generic;
using System;

public class Paciente : Perfil
{
    private HistoriaClinica historia_clinica;
    private float latitud;
    private float longitud;

    public HistoriaClinica HistoriaClinica
    {
        get => historia_clinica;
        set => historia_clinica = value;
    }
    public float Latitud
    {
        get => latitud;
        set => latitud = value;
    }
    public float Longitud
    {
        get => longitud;
        set => longitud = value;
    }

    public Paciente(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, HistoriaClinica historia_clinica, float latitud, float longitud)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.historia_clinica = historia_clinica;
        this.latitud = latitud;
        this.longitud = longitud;
    }
}