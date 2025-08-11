using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear una historia clínica de ejemplo
        var historia = new HistoriaClinica("O+", 30, false, "Medellín", "Verde", new List<string> { "Asma" });

        // Crear un paciente de ejemplo
        var paciente = new Paciente(1, "Juan", "juan@mail.com", 123456789, "CC", 12345, "pass", historia, 6.25184f, -75.56359f);

        // Crear el servicio
        var pacienteService = new PacienteService();

        // Probar Geolocalizar
        var ubicacion = pacienteService.Geolocalizar(paciente);
        Console.WriteLine($"Ubicación: latitud={ubicacion.latitud}, longitud={ubicacion.longitud}");

        // Probar Crear_Alerta
        var alerta = pacienteService.Crear_Alerta(paciente, ubicacion, paciente);
        Console.WriteLine($"Alerta creada para paciente: {alerta.Paciente?.HistoriaClinica?.TipoSangre}");

        // Probar Llamar
        var resultadoLlamada = pacienteService.Llamar(paciente, 123456789);
        Console.WriteLine(resultadoLlamada);
    }
}
