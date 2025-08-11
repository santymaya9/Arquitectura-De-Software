using System.Collections.Generic;

public class Operador : Perfil
{
    private int numOperador;
    private AlertaEmergencia[] alertasEmergencia;

    public Operador(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, int numOperador, AlertaEmergencia[] alertasEmergencia)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.numOperador = numOperador;
        this.alertasEmergencia = alertasEmergencia;
    }

    public void Asignar_paramedico(Paramedico paramedico)
    {
        // Implementación de ejemplo
    }

    public override string Asignar_triaje(Paciente paciente, string nivel_triaje)
    {
        // Implementación de ejemplo
        return "";
    }

    public override void Trazar_ruta(AlertaEmergencia alerta, List<CentroMedico> centros_medicos)
    {
        // Implementación de ejemplo
    }

    public override void Mostrar_alerta(AlertaEmergencia alerta_emergencia)
    {
        // Implementación de ejemplo
    }

    public override void Llamar(int telefono)
    {
        // Implementación de ejemplo
    }
}
