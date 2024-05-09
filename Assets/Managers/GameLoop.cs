using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this class is responsible for managing the control flow of the game



public class GameLoop : MonoBehaviour
{


    Setup setup;
  
    Units.Unit selectedunit;  // need to get the result of confirm here

    //maybe consider also moving these to setup
    PlayerInput playerInput;
    MechInput mechInput;
    TankInput tankInput;
    SoldierInput soldierInput;

    List<IMovement> movers;
    List<IAction> actors;
    List<IInteraction> interactors;

    private void Awake()
    {

        InitalizeGame();
    }

    void InitalizeGame()
    {
        setup = new();

        playerInput = setup.playerInput;

        mechInput = setup.mechInput;
        tankInput = setup.tankInput;
        soldierInput = setup.soldierInput;

        movers = new List<IMovement> { mechInput, tankInput, soldierInput };
        actors = new List<IAction> { mechInput, tankInput, soldierInput };
        interactors = new List<IInteraction> { mechInput, tankInput, soldierInput };
        

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

    void TurnBased()
    {
        // if selection, do unitmanagement script
        //if activation, do unitactivationscript
        UnitManagementScript.unitManagement.SelectUnit();
        if (PhaseManager.Phases.Selection == setup.phaseManager.GetCurrentPhase())
        {
            ExecuteSelection();
        }
    }
    void RealTime()
    {
        if (PhaseManager.Phases.Activation == setup.phaseManager.GetCurrentPhase())
        {
            ExecuteInput();
        }

    }
    void ExecuteInput()
    {
        //if unit is active
        //OR
        //then call these passing in the active unit //this is the one we are doing
        //OR
        //shove the active unit to the front of the list

        foreach (IMovement mover in movers)
        {
            mover.MoveUp(selectedunit);
            mover.MoveDown();
            mover.MoveLeft();
            mover.MoveRight();
        }
        foreach (IAction actor in actors)
        {
            actor.FirePrimary();
            actor.FireSecondary();
            actor.SwitchMode();
            actor.ChangeArmor();
        }
        foreach (IInteraction interactor in interactors)
        {
            interactor.Interact();
        }

        setup.mechInput.EndTurn();
        setup.soldierInput.EndTurn();
        setup.tankInput.EndTurn();

        setup.mechInput.ViewObjectives();
        setup.soldierInput.ViewObjectives();
        setup.tankInput.ViewObjectives();


    }
    void ExecuteSelection()
    {
        playerInput.PressLeft();
        playerInput.PressRight();
        selectedunit = playerInput.Confirm();
    }

}
