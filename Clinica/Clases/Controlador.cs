using System.Collections.Generic;

public class Controlador
{
    private List<Cuenta> cuentas;
    private List<CentroMedico> centrosMedicos;

    public List<Cuenta> Cuentas => cuentas ?? new List<Cuenta>();
    public List<CentroMedico> CentrosMedicos => centrosMedicos ?? new List<CentroMedico>();

    public Controlador(List<Cuenta> cuentas = null, List<CentroMedico> centrosMedicos = null)
    {
        this.cuentas = cuentas ?? new List<Cuenta>();
        this.centrosMedicos = centrosMedicos ?? new List<CentroMedico>();
    }

    public void AgregarCentroMedico(string nombre, string correo, string celular, int tipoCelular, int tipoPerfil) { }
}
