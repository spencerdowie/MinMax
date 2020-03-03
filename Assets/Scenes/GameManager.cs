using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerType
{
    X = 1,
    O = -1
}
public class GameManager : MonoBehaviour
{
    public int[] tiles = new int[9];
    public PlayerType player;

    public void ClickTile(int i)
    {
        if(tiles[i] == 0)
        {
            tiles[i] = (int)player;
            MinMax((int[])tiles.Clone(), false);
        }
    }

    public int MinMax(int[] state, bool max)
    {
        state[8] = (int)player;
        return 0;
    }

    public int CheckWin()
    {
        int win = 0;
        for(int i = 0; i < 9; i+=3)
        {
            win = tiles[i] + tiles[i + 1] + tiles[i + 2];
            if (win == 3 || win == -3)
                return win;
        }
        for (int i = 0; i < 3; i++)
        {
            win = tiles[i] + tiles[i + 3] + tiles[i + 6];
            if (win == 3 || win == -3)
                return win;
        }
        win = tiles[0] + tiles[4] + tiles[8];
        if (win == 3 || win == -3)
            return win;
        win = tiles[2] + tiles[4] + tiles[6];
        if (win == 3 || win == -3)
            return win;
        return 0;
    }
}
