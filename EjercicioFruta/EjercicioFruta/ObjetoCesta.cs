using EjercicioFruta;
using System.Collections.Generic;

public class ObjetoCesta
{
    static List<Frutas> cesta_frutas = new List<Frutas>();

    public ObjetoCesta()
    {
    }

    public static void AgregarProductoCesta(Frutas fruta)
    {
        cesta_frutas.Add(fruta);
    }

    public static void EliminarFrutaCesta(Frutas fruta)
    {
        cesta_frutas.Remove(fruta);
    }

    public static List<Frutas> ObtenerListaFrutas()
    {
        return cesta_frutas;
    }
}
