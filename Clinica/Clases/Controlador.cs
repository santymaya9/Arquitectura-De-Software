using System.Collections.Generic;

public class Controlador
{
    private List<Cuenta> cuentas;
    private List<CentroMedico> centrosMedicos;

    public List<Cuenta> Cuentas => cuentas ?? new List<Cuenta>();
    public List<CentroMedico> CentrosMedicos => centrosMedicos ?? new List<CentroMedico>();

    public Controlador()
    {
        cuentas = new List<Cuenta>();
        centrosMedicos = new List<CentroMedico>();
    }

    public void AgregarCentroMedico(string nombre, string correo, string celular, int tipoCelular, int tipoPerfil) { }
}
