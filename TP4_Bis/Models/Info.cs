namespace TP4_Bis.Models;
using System.Collections.Generic;
public static class Info
{
    private static List<Pais> ListaPaises {get;set;} = new List<Pais>();

private static void IniciarLista()
{
    ListaPaises.Add(new Pais ("Argentina", "Bandera_Argentina.png", 732432423 ,new DateOnly(1816,9,7),"Obelisco", "HimnoArgentina.mp3"));
    ListaPaises.Add(new Pais ("Italia", "Bandera_Italia.png", 423432432 ,new DateOnly(1946, 6, 9),"Coliseo romano", "HimnoItalia.mp3"));
    ListaPaises.Add(new Pais ("Brasil", "Bandera_Brasil.png", 8234234 ,new DateOnly(1930, 3, 2),"Cristo redentor", "HimnoBrasil.mp3"));
    ListaPaises.Add(new Pais ("España", "Bandera_España.png", 20000 ,new DateOnly(1850, 7, 2),"Alhambra", "HimnoEspaña.mp3"));
    ListaPaises.Add(new Pais ("Alemania", "Bandera_Alemania.png", 432432 ,new DateOnly(1810, 10, 5),"Puerta de Brandeburgo", "HimnoAlemania.mp3"));
}
public static List<Pais> ListarPaises()
{
    if(ListaPaises.Count==0)IniciarLista();
    return ListaPaises;
}
public static Pais DetallePais(string Nombre)
{
    Pais PaisBuscado = null;
    bool encontro = false;
    foreach (Pais item in ListaPaises)
    {
        if(Nombre == item.nombre){
            encontro = true;
            PaisBuscado = item;
        }
    }
    if(encontro)return PaisBuscado;
    else
    {
        return null;
    }
}

}
