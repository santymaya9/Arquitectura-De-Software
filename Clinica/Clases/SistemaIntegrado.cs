using System;
using System.Collections.Generic;

public class SistemaIntegrado : ICreacion
{
    private string nombre;
    private int telefono;
    private List<Cuenta> cuentas;
    private List<CentroMedico> centroMedico;

    public string Nombre => string.IsNullOrWhiteSpace(nombre) ? "Sin nombre" : nombre;
    public int Telefono => telefono;
    public List<Cuenta> Cuentas => cuentas ?? new List<Cuenta>();
    public List<CentroMedico> CentroMedico => centroMedico ?? new List<CentroMedico>();

    public SistemaIntegrado(string nombre, List<Cuenta> cuentas, List<CentroMedico> centroMedico)
    {
        this.nombre = nombre;
        this.cuentas = cuentas;
        this.centroMedico = centroMedico;
    }

    public string Iniciar_sesion(Cuenta cuenta)
    {
        // Implementaci�n de ejemplo
        return cuenta != null ? "Sesi�n iniciada" : "Cuenta inv�lida";
    }

    public string Eliminar(Cuenta cuenta, Cuenta iniciada)
    {
        // Implementaci�n de ejemplo
        return cuenta != null && iniciada != null ? "Cuenta eliminada" : "Error al eliminar";
    }

    public void Leer(Cuenta cuenta)
    {
        // Implementaci�n de ejemplo
    }

    public void Agregar(uint id, string nombre, string correo, string celular, int tipo_cedula, string cedula, int contrasena, string tipo_perfil)
    {
        // Implementaci�n de ejemplo
    }
}
