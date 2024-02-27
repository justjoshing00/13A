using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    class PlayerManager
    {

        
        List<Player> players_;
        private int i;


    public PlayerManager(List<Player> player)
    {
        init(player);
        i = 0;
    }

    void init(List<Player> player)
    {
        players_ = player;
        
    }



    public void NextTurn()
        {
        //bug
        i = i >= players_.Count() - 1 ?  players_[0].playerID : i++;   // this was only going to work as long as player ID was not arbirtrary 

    }

    public string GetCurrentPlayerName()
    {
        return players_[i].playername;
    }
    public Player GetCurrentPlayer()
    {
        return players_[i];
    }
    public List<Units.Unit> GetCurrentPlayersUnits()
    {
        return players_[i].units;
    }


}






