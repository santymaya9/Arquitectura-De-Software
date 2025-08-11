using System.Collections.Generic;

public class Paramedico : Perfil
{
    private int numParamedico;
    private List<AlertaEmergencia> alertasAsignadas;
    private List<RegistroAtencion> registroAtenciones;
    private int limiteAlertas;

    public int NumParamedico => numParamedico;
    public List<AlertaEmergencia> AlertasAsignadas => alertasAsignadas ?? new List<AlertaEmergencia>();
    public List<RegistroAtencion> RegistroAtenciones => registroAtenciones ?? new List<RegistroAtencion>();
    public int LimiteAlertas => limiteAlertas;

    public Paramedico(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, int numParamedico, int limiteAlertas, List<AlertaEmergencia> alertasAsignadas = null, List<RegistroAtencion> registroAtenciones = null)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.numParamedico = numParamedico;
        this.limiteAlertas = limiteAlertas;
        this.alertasAsignadas = alertasAsignadas ?? new List<AlertaEmergencia>();
        this.registroAtenciones = registroAtenciones ?? new List<RegistroAtencion>();
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
