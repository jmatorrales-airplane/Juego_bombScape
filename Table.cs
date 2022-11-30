class Table
{
    private int[,] sizeTable { get; set; }

    private int[,]? bombs;
    private static int[,]? pos_bomb { get; set; }
    private int[]? pos_vict { get; set; }
    private static int[]? pos_player { get; set; }

    public string symbol_player = "X";
    public string symbol_empty = "O";
    public string symbol_vict = "$";
    public string symbol_bomb = "*"; // not
    public string symbol_move = "-"; // not

    public void createTable(int sizeTable/*, int nBombs*/)
    {
        this.sizeTable = new int[sizeTable, sizeTable];
        //createBombs(nBombs, sizeTable);
        createVictoryGate(sizeTable);
        createPositionPlayer(sizeTable);
    }

    public void viewTable()
    {
        for (int i = 0; i < sizeTable.GetLength(0); i++)
        {
            for (int j = 0; j < sizeTable.GetLength(1); j++)
            {
                if (pos_player[0] == i && pos_player[1] == j) Console.Write("X");
                else if (pos_vict[0] == i && pos_vict[1] == j) Console.Write("$");
                else Console.Write("O");
            }
            Console.WriteLine(""); // no tocar
        }
    }

    private static void createBombs(int totalNumBombs)
    {
        pos_bomb = new int[totalNumBombs, 2];

        // Creamos un bucle para crear las bombas
        for (int i = 0; i < totalNumBombs; i++)
        {
            pos_bomb[i, 0] = random(totalNumBombs);
            pos_bomb[i, 1] = random(totalNumBombs);

            Console.WriteLine($"Pos_bomb {i}: " + pos_bomb[i, 0] + ", " + pos_bomb[i, 1]);
        }

        // Ordenamos la lista, solo la primera posicion para poder imprimir todas y luego con la segunda posicion
        for (int i = 0; i < totalNumBombs; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (pos_bomb[j, 0] > pos_bomb[j + 1, 0])
                {
                    int x = pos_bomb[j, 0];

                    pos_bomb[j, 0] = pos_bomb[j + 1, 0];
                    pos_bomb[j + 1, 0] = x;
                }
                if (pos_bomb[j, 0] == pos_bomb[j + 1, 0] && pos_bomb[j, 1] > pos_bomb[j + 1, 1])
                {
                    int x = pos_bomb[j, 0];

                    pos_bomb[j, 1] = pos_bomb[j + 1, 1];
                    pos_bomb[j + 1, 1] = x;
                }

            }

        }
    }

    private void createVictoryGate(int sizeTable)
    {
        pos_vict = new int[2];
        pos_vict[0] = random(sizeTable);
        pos_vict[1] = random(sizeTable);
    }

    private static void createPositionPlayer(int sizeTable)
    {
        pos_player = new int[2];
        pos_player[0] = random(sizeTable);
        pos_player[1] = random(sizeTable);

        Console.WriteLine($"Pos_jugador: {pos_player[0]}, {pos_player[1]}");
    }

    public void deleteTable()
    {
        sizeTable = null;
        pos_bomb = null;
        pos_vict = null;
        pos_player = null;
    }

    private static int random(int max)
    {
        Random random = new Random();
        return random.Next(0, max);
    }
}
