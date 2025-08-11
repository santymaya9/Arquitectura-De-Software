using System;

public class PacienteService : IPacienteService
{
    public (float latitud, float longitud) Geolocalizar(Paciente paciente)
    {
        // Usar directamente los atributos del modelo
        return (paciente.Latitud, paciente.Longitud);
    }

    public AlertaEmergencia Crear_Alerta(Paciente paciente, (float latitud, float longitud) geolocalizar, Paciente pacienteAlerta)
    {
        // Crear la alerta usando los datos del modelo
        return new AlertaEmergencia(
            "pendiente",
            pacienteAlerta,
            geolocalizar.latitud,
            geolocalizar.longitud,
            DateTime.Now,
            DateTime.Now,
            null,
            null
        );
    }

    public string Llamar(Paciente paciente, int telefono)
    {
        // Retornar cadena de texto en vez de imprimir
        return $"Paciente llamado al teléfono {telefono}";
    }
}
