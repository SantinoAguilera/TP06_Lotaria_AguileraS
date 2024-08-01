static class Game
{
    //Constants
    const int cantMaxTurnos = 15;
    
    //Atributes
    static int vidaNorte = 3;
    static int vidaCentro = 3;
    static int vidaSur = 3;
    static int turno = 0;

    //Methods
    public static int[] randomOgres()
    {
        Random rnd = new Random();
        int[] movimientosOgros = new int[3];
        for(int i = 0; i < 3; i++)
        {
            movimientosOgros[i] = rnd.Next(0,3);
        }
        return movimientosOgros;
    }
    public static int[] combatResult(int[] movimientosJugador)
    {
        int[] movimientosOgros = randomOgres();
        int[] resultados = new int[3];
        for(int i = 0; i < 3; i++)
        {
            if (movimientosJugador[i] == 0 && movimientosOgros[i] == 2)
            {
                resultados[i] = 1;
            }
            else if (movimientosJugador[i] == 1 && movimientosOgros[i] == 0)
            {
                resultados[i] = 1;
            }
            else if (movimientosJugador[i] == 2 && movimientosOgros[i] == 1)
            {
                resultados[i] = 1;
            }
            else if (movimientosJugador[i] == movimientosOgros[i])
            {
                resultados[i] = 0;
            }
            else
            {
                resultados[i] = -1;
            }
        }
        return resultados;
    }
}