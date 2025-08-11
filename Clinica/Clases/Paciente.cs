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

    // Crea una alerta de emergencia usando la geolocalización y el paciente recibidos como parámetros
    public AlertaEmergencia Crear_Alerta((float latitud, float longitud) geolocalizar, Paciente paciente)
    {
        return new AlertaEmergencia(
            "pendiente",
            paciente,
            geolocalizar.latitud,
            geolocalizar.longitud,
            DateTime.Now,
            DateTime.Now,
            null,
            null
        );
    }

    public override void Llamar(int telefono)
    {
        // Implementación específica de Paciente
    }

    public override void Trazar_ruta(AlertaEmergencia alerta, List<CentroMedico> centros_medicos)
    {
        // Implementación específica de Paciente
    }

    public override string Asignar_triaje(Paciente paciente, string nivel_triaje)
    {
        // Implementación específica de Paciente
        return "";
    }

    public override void Mostrar_alerta(AlertaEmergencia alerta_emergencia)
    {
        // Implementación específica de Paciente
    }
}
