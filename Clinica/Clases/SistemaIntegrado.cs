using System;
using System.Collections.Generic;

public class SistemaIntegrado : ICreacion
{
    private string nombre;
    private int telefono;
    private List<Cuenta> cuentas;
    private List<CentroMedico> centroMedico;

    public string Nombre => string.IsNullOrWhiteSpace(nombre) ? "Sin nombre" : nombre;
    public int Telefono => telefono == default ? -1 : telefono;
    public List<Cuenta> Cuentas => cuentas ?? new List<Cuenta>();
    public List<CentroMedico> CentroMedico => centroMedico ?? new List<CentroMedico>();

    public SistemaIntegrado(string nombre, List<Cuenta> cuentas = null, List<CentroMedico> centroMedico = null)
    {
        this.nombre = nombre;
        this.cuentas = cuentas ?? new List<Cuenta>();
        this.centroMedico = centroMedico ?? new List<CentroMedico>();
    }

    public string Iniciar_sesion(Cuenta cuenta)
    {
        // Implementación de ejemplo
        return cuenta != null ? "Sesión iniciada" : "Cuenta inválida";
    }

    public string Eliminar(Cuenta cuenta, Cuenta iniciada)
    {
        // Implementación de ejemplo
        return cuenta != null && iniciada != null ? "Cuenta eliminada" : "Error al eliminar";
    }

    public void Leer(Cuenta cuenta)
    {
        // Implementación de ejemplo
    }

    public void Agregar(uint id, string nombre, string correo, string celular, int tipo_cedula, string cedula, int contrasena, string tipo_perfil)
    {
        // Implementación de ejemplo
    }
}
