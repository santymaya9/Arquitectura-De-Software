using System.Collections.Generic;

public class Paramedico : Perfil
{
    private int numParamedico;
    private AlertaEmergencia alertasAsignadas;
    private RegistroAtencion registroAtenciones;
    private int limiteAlertas;

    public Paramedico(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, int numParamedico, int limiteAlertas)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.numParamedico = numParamedico;
        this.limiteAlertas = limiteAlertas;
    }

    public override void Llamar(int telefono)
    {
        // Implementaci�n espec�fica de Paramedico
    }

    public override void Trazar_ruta(AlertaEmergencia alerta, List<CentroMedico> centros_medicos)
    {
        // Implementaci�n espec�fica de Paramedico
    }

    public override string Asignar_triaje(Paciente paciente, string nivel_triaje)
    {
        // Implementaci�n espec�fica de Paramedico
        return "";
    }

    public override void Mostrar_alerta(AlertaEmergencia alerta_emergencia)
    {
        // Implementaci�n espec�fica de Paramedico
    }

    public void Actualizar_estado_alerta(AlertaEmergencia alerta, string estado) { }
    public void Mostrar_registro(RegistroAtencion registro_atencion) { }
}
