using System;
using System.Collections.Generic;

public class HistoriaClinica
{
    private string tipo_sangre;
    private int edad;
    private bool marcapasos;
    private string municipio;
    private string nivel_triaje;
    private List<string> l_enfermedades_preexistentes;

    public string TipoSangre => string.IsNullOrWhiteSpace(tipo_sangre) ? "Sin tipo de sangre" : tipo_sangre;
    public int Edad => edad;
    public bool Marcapasos => marcapasos;
    public string Municipio => string.IsNullOrWhiteSpace(municipio) ? "Sin municipio" : municipio;
    public string NivelTriaje => string.IsNullOrWhiteSpace(nivel_triaje) ? "Sin nivel de triaje" : nivel_triaje;
    public List<string> EnfermedadesPreexistentes => l_enfermedades_preexistentes ?? new List<string>();

    public HistoriaClinica(string tipo_sangre, int edad, bool marcapasos, string municipio, string nivel_triaje, List<string> l_enfermedades_preexistentes)
    {
        this.tipo_sangre = tipo_sangre;
        this.edad = edad;
        this.marcapasos = marcapasos;
        this.municipio = municipio;
        this.nivel_triaje = nivel_triaje;
        this.l_enfermedades_preexistentes = l_enfermedades_preexistentes;
    }
}
