public abstract class Perfil
{
    private uint id;
    private string nombre;
    private string correo;
    private int celular;
    private string tipo_cedula;
    private int cedula;
    private string contrasena;

    public uint Id => id;
    public string Nombre => nombre;
    public string Correo => correo;
    public int Celular => celular;
    public string TipoCedula => tipo_cedula;
    public int Cedula => cedula;
    public string Contrasena => contrasena;

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
}
