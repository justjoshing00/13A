using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO have setup init the prefabs

public class Setup
{
   
   
    //[SerializeField] Prefabs prefabs_;

    private List<Units.Unit> player1unitList { get; set; }
    public List<Units.Unit> Player1UnitList => player1unitList;
    private List<Units.Unit> player2unitList { get; set; }
    public List<Units.Unit> Player2UnitList => player2unitList;
    private List<Player> playerList { get; set; }
    public List<Player> PlayerList => playerList;
   

   
    public Setup()
    {
        player1unitList = new List<Units.Unit>();
        player2unitList = new List<Units.Unit>();
        playerList = new List<Player>();
        

        
        
        SystemSetup();
    }

    //TODO: map units to players
    void WorldSetup()
    {
        UnitSetup();
    }

    void UnitSetup()
    {
        //TODO: we could add all these to the lists in one step
        Player1UnitList.Add(new Units.Mech("Calamity", 0, false));
        Player1UnitList.Add(new Units.Soldier("Iver", 1, false));
        Player1UnitList.Add(new Units.Tank("Aegis", 2, false));
        
        Player2UnitList.Add(new Units.Mech("Pragmatic", 3, false));
        Player2UnitList.Add(new Units.Soldier("Base", 4, false));
        Player2UnitList.Add(new Units.Tank("Tower", 5, false));


        //PrefabSetup();

    }
    //setup the systems

    void SystemSetup()
    {
        PlayerSetup();
        PhaseSetup();
        WorldSetup();

     }
    void PlayerSetup()
    {

        PlayerList.Add(new Player("player 1", 0, false, player1unitList));
        PlayerList.Add(new Player("player 2", 1, true, player2unitList));
    }

    void PhaseSetup()
    {
    }
    //public void PrefabSetup()
    //{
    //    prefabs_.SetupMech(new Vector3(2.0f,0.0f,0.0f));

    //    prefabs_.SetupSoldier(new Vector3(-2.0f, 0.0f, 0.0f));
    //    prefabs_.SetupTank(new Vector3(0.0f, 0.0f, -2.0f));
    //}
}

