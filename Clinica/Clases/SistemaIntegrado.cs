using System;
using System.Collections.Generic;

public class SistemaIntegrado
{
    private string nombre;
    private int telefono;
    private List<Cuenta> l_cuentas;
    private List<CentroMedico> l_centroMedico;

    public string Nombre => string.IsNullOrWhiteSpace(nombre) ? "Sin nombre" : nombre;
    public int Telefono => telefono;
    public List<Cuenta> Cuentas => l_cuentas;
    public List<CentroMedico> CentroMedico => l_centroMedico;

    public SistemaIntegrado(string nombre, List<Cuenta> l_cuentas, List<CentroMedico> l_centroMedico)
    {
        this.nombre = nombre;
        this.l_cuentas = l_cuentas ?? new List<Cuenta>();
        this.l_centroMedico = l_centroMedico ?? new List<CentroMedico>();
    }
}
