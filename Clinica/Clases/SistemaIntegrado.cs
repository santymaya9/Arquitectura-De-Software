using System;
using System.Collections.Generic;

public class SistemaIntegrado
{
    private string nombre;
    private int telefono;
    private List<Cuenta> l_cuentas;
    private List<CentroMedico> l_centroMedico;

    public string Nombre
    {
        get => string.IsNullOrWhiteSpace(nombre) ? "Sin nombre" : nombre;
        set => nombre = value;
    }
    public int Telefono
    {
        get => telefono;
        set => telefono = value;
    }
    public List<Cuenta> Cuentas
    {
        get => l_cuentas;
        set => l_cuentas = value;
    }
    public List<CentroMedico> CentroMedico
    {
        get => l_centroMedico;
        set => l_centroMedico = value;
    }

    public SistemaIntegrado(string nombre, List<Cuenta> l_cuentas, List<CentroMedico> l_centroMedico)
    {
        this.nombre = nombre;
        this.l_cuentas = l_cuentas ?? new List<Cuenta>();
        this.l_centroMedico = l_centroMedico ?? new List<CentroMedico>();
    }
}
