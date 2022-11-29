using System.Numerics;

class Player
{
    public String namePlayer { get; set; }
    public int lifePlayer { get; set; }

    public void createPlayer()
    {

    }

    public void deletePlayer()
    {
        namePlayer = null;
        lifePlayer = 0;
    }
}
