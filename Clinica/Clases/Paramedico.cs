using System.Collections.Generic;

public class Paramedico : Perfil
{
    private int numParamedico;
    private List<AlertaEmergencia> alertasAsignadas;
    private List<RegistroAtencion> registroAtenciones;
    private int limiteAlertas;

    public int NumParamedico
    {
        get => numParamedico;
        set => numParamedico = value;
    }
    public List<AlertaEmergencia> AlertasAsignadas
    {
        get => alertasAsignadas;
        set => alertasAsignadas = value;
    }
    public List<RegistroAtencion> RegistroAtenciones
    {
        get => registroAtenciones;
        set => registroAtenciones = value;
    }
    public int LimiteAlertas
    {
        get => limiteAlertas;
        set => limiteAlertas = value;
    }

    public Paramedico(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, int numParamedico, int limiteAlertas, List<AlertaEmergencia> alertasAsignadas = null, List<RegistroAtencion> registroAtenciones = null)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.numParamedico = numParamedico;
        this.limiteAlertas = limiteAlertas;
        this.alertasAsignadas = alertasAsignadas ?? new List<AlertaEmergencia>();
        this.registroAtenciones = registroAtenciones ?? new List<RegistroAtencion>();
    }
}
