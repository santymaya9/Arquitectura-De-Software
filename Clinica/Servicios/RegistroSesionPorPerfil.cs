using System;

public class RegistroSesionPaciente : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // L�gica espec�fica para registrar sesi�n de paciente
    }
}

public class RegistroSesionOperador : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // L�gica espec�fica para registrar sesi�n de operador
    }
}

public class RegistroSesionParamedico : IRegistroSesion
{
    public void RegistrarSesion(Cuenta cuenta)
    {
        // L�gica espec�fica para registrar sesi�n de param�dico
    }
}
