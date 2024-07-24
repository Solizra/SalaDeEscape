static class Escape{
private static string[] incognitasSalas;

public static int estadoJuego = 1;

private static void InicializarJuego()
{
    incognitasSalas = new string[] {"", "5", "8", "18", "1", "58181" };
}
public static int GetEstadoJuego()
{
    return estadoJuego;
}
public static bool ResolverSala(int Sala, string Incognita)
{
    if (incognitasSalas == null || incognitasSalas.Length == 0)
    {
        InicializarJuego();
    }

    if (Sala != estadoJuego)
    {
        return false;
    }

    else if (Incognita==incognitasSalas[Sala]) 
    {
        estadoJuego++;
        return true;
    }
    else if(Sala==0){
        estadoJuego=1;
        return true;
    }
    
    else return false;

}
}