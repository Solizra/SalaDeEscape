static class Escape{
private static string[] incognitasSalas;

static int estadoJuego = 1;

private static void InicializarJuego()
{
incognitasSalas = new string[] { "1", "2", "3", "4" };
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

    else if (Incognita==incognitasSalas[Sala-1]) 
    {
        estadoJuego++;
        return true;
    }
    
    else return false;

}
}