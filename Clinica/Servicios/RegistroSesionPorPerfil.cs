using System;

public class RegistroSesionPaciente : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // Lógica específica para registrar sesión de paciente
    }
}

public class RegistroSesionOperador : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // Lógica específica para registrar sesión de operador
    }
}

public class RegistroSesionParamedico : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // Lógica específica para registrar sesión de paramédico
    }
}
