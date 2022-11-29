class Table
{
    private int[,] sizeTable { get; set; }

    private int[,]? bombs;
    private int[,] pos_bomb { get; set; }
    private int[,] pos_vict { get; set; }

    public int[,] pos_player { get; set; }

    public string symbol_player = "X";
    public string symbol_empty = "O";
    public string symbol_vict = "$";
    public string symbol_bomb = "*"; // not
    public string symbol_move = "-"; // not

    public void createTable(int sizeTable, int nBombs)
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
                if (pos_player[i,j].Equals(sizeTable[i,j]))
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("@");
                }
            }
            Console.WriteLine(""); // no tocar
        }
    }

    //private void createBombs(int sizeBombs, int positionBomb)
    //{
    //    //bombs = new int[sizeBombs];
    //    for(int i = 0; i < sizeBombs; i++)
    //    {
    //        pos_bomb = new int[random(positionBomb), random(positionBomb)];

    //        for (int j = 0; j < bombs.Count; j++)
    //        {
    //            if(bombs.Count == 0)
    //            {
    //                bombs.Add(pos_bomb[0, 0]);
    //            }
    //            else
    //            {
    //                //if (bombs.Find())
    //                bombs = pos_bomb[0,0];
    //            }
    //        }
    //    }
    //}

    private void createVictoryGate(int sizeTable)
    {
        pos_vict = new int[random(sizeTable), random(sizeTable)];
    }

    private void createPositionPlayer(int sizeTable)
    {
        pos_player = new int[random(sizeTable),random(sizeTable)];
    }

    public void deleteTable()
    {
        sizeTable = null;
        pos_bomb = null;
        pos_vict = null;
        pos_player = null;
    }

    private int random(int maxTable)
    {        
        Random random = new Random();
        return random.Next(0,maxTable);
    }
}
