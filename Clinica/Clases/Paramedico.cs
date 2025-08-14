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


}
