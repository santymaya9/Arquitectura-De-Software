using System.Collections.Generic;

public class Operador : Perfil
{
    private int num_operador;
    private List<AlertaEmergencia> l_alertasEmergencia;

    public int NumOperador => num_operador;
    public List<AlertaEmergencia> AlertasEmergencia => l_alertasEmergencia;

    public Operador(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena, int num_operador, List<AlertaEmergencia> l_alertasEmergencia)
        : base(id, nombre, correo, celular, tipo_cedula, cedula, contrasena)
    {
        this.num_operador = num_operador;
        this.l_alertasEmergencia = l_alertasEmergencia ?? new List<AlertaEmergencia>();
    }
}
