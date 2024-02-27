using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class is responsible for managing the control flow of the game

 

public class GameLoop : MonoBehaviour
{
    Setup setup;
    PlayerManager playerManager_;
    PhaseManager phaseManager_;

    UnitManagementScript unitManagementScript_;
    InputScript inputScript_;
    Units.Unit selectedunit;

    private void Awake()
    {
        InitalizeGame();
        
    }

    void InitalizeGame()
    {
        setup = new();
        playerManager_ = new(setup.PlayerList);
        phaseManager_ = new();
        unitManagementScript_ = new(phaseManager_, playerManager_);
        inputScript_ = new();


    }


    private void Update()
    {
        CoreLoop();
        
    }

    //need to figure out how to call this
    void CoreLoop()
    {
        TurnBased();
        RealTime();
    }


    void RealTime()
    {
        if (PhaseManager.Phases.Activation == phaseManager_.GetCurrentPhase())
        {
            inputScript_.ExecuteUpdate(unitManagementScript_.SelectedUnit);
        }

    }

    //At some pont call groups of things in order, rather than just one thing
    void TurnBased()
    {
        // if selection, do unitmanagement script
        //if activation, do unitactivationscript
        if (PhaseManager.Phases.Selection == phaseManager_.GetCurrentPhase())
        {
            unitManagementScript_.SelectUnit();
            
        }
    }


}
