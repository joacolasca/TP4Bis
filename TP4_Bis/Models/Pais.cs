namespace TP4_Bis.Models;
using System.Collections.Generic;
public class Pais
{
    public string nombre {get; private set;}
    public string imgBandera {get; private set;}
    public int Poblacion {get; private set;}
    public DateOnly FechaIndependencia {get; private set;}
    public string AtractivosTuristicos {get; private set;}
    public string AudioHimno {get; private set;}

    public Pais(string nom, string imgBand, int pobla ,DateOnly FechaIndepen, string AtractivosTuristic, string AudioHim){
    nombre = nom;
    imgBandera = imgBand;
    Poblacion = pobla;
    FechaIndependencia = FechaIndepen;
    AtractivosTuristicos = AtractivosTuristic;
    AudioHimno = AudioHim;
}
}