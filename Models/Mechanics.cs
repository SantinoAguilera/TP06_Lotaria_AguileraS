static class Mechanics
{
    //Constants
    const int cantMaxTurnos = 15;
    
    //Atributes
    static public int vidaNorte = 3;
    static public int vidaCentro = 3;
    static public int vidaSur = 3;
    static public int vidaDesembarco = 4;
    static public int turno = 0;

    //Methods
    public static int[] RandomOrks()
    {
        Random rnd = new Random();
        int[] movimientosOrcos = new int[3];
        List<int> movimientosPosibles = new List<int> { 0, 1, 2 };

        for (int i = 0; i < 3; i++)
        {
            int ciclo = rnd.Next(0, movimientosPosibles.Count);
            movimientosOrcos[i] = movimientosPosibles[ciclo];
            movimientosPosibles.RemoveAt(ciclo);
        }

        return movimientosOrcos;
    }
    
    public static int[] CombatResult(int[] movimientosJugador)
    {
        int[] movimientosOrcos = RandomOrks();
        int[] resultados = new int[3];
        for(int i = 0; i < 3; i++)
        {
            if (movimientosJugador[i] == 0 && movimientosOrcos[i] == 2)
            {
                resultados[i] = 1;
            }
            else if (movimientosJugador[i] == 1 && movimientosOrcos[i] == 0)
            {
                resultados[i] = 1;
            }
            else if (movimientosJugador[i] == 2 && movimientosOrcos[i] == 1)
            {
                resultados[i] = 1;
            }
            else if (movimientosJugador[i] == movimientosOrcos[i])
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