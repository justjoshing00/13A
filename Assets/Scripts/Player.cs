using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    public string playername;
    public int playerID;
    bool activePlayer;
    public List<Units.Unit> units; // player holds a list to the units it owns


    public Player(string playername_, int playerID_, bool active, List<Units.Unit> inputUnits)
    {
        playername = playername_;
        playerID = playerID_;
        activePlayer = active;
        units = inputUnits;
    }

    public void SetActivePlayer()
    {
        activePlayer = true;
    }

    public bool GetActivePlayer()
    {
        return activePlayer;
    }
}