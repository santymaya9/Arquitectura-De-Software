public abstract class Perfil : Igestion_recursos
{
    protected uint id;
    protected string nombre;
    protected string correo;
    protected int celular;
    protected string tipo_cedula;
    protected int cedula;
    protected string contrasena;

    public Perfil(uint id, string nombre, string correo, int celular, string tipo_cedula, int cedula, string contrasena)
    {
        this.id = id;
        this.nombre = nombre;
        this.correo = correo;
        this.celular = celular;
        this.tipo_cedula = tipo_cedula;
        this.cedula = cedula;
        this.contrasena = contrasena;
    }

    public abstract void Llamar(int telefono);
    public abstract void Trazar_ruta(AlertaEmergencia alerta, List<CentroMedico> centros_medicos);
    public abstract string Asignar_triaje(Paciente paciente, string nivel_triaje);
    public abstract void Mostrar_alerta(AlertaEmergencia alerta_emergencia);
}
