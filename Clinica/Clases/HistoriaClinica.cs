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

    public string TipoSangre
    {
        get => string.IsNullOrWhiteSpace(tipo_sangre) ? "Sin tipo de sangre" : tipo_sangre;
        set => tipo_sangre = value;
    }
    public int Edad
    {
        get => edad == default ? -1 : edad;
        set => edad = value;
    }
    public bool Marcapasos
    {
        get => marcapasos;
        set => marcapasos = value;
    }
    public string Municipio
    {
        get => string.IsNullOrWhiteSpace(municipio) ? "Sin municipio" : municipio;
        set => municipio = value;
    }
    public string NivelTriaje
    {
        get => string.IsNullOrWhiteSpace(nivel_triaje) ? "Sin nivel de triaje" : nivel_triaje;
        set => nivel_triaje = value;
    }
    public List<string> EnfermedadesPreexistentes
    {
        get => l_enfermedades_preexistentes;
        set => l_enfermedades_preexistentes = value;
    }

    public HistoriaClinica(string tipo_sangre, int edad, bool marcapasos, string municipio, string nivel_triaje, List<string> l_enfermedades_preexistentes = null)
    {
        this.tipo_sangre = tipo_sangre;
        this.edad = edad;
        this.marcapasos = marcapasos;
        this.municipio = municipio;
        this.nivel_triaje = nivel_triaje;
        this.l_enfermedades_preexistentes = l_enfermedades_preexistentes ?? new List<string>();
    }
}
