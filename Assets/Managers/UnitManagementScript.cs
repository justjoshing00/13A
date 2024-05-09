using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// we take the list of units owned by the activeplayer, and if the phase is the selection phase.
// we select the next unit in the list

//check if phase is selection phase
//search list of players and
//get activeplayer from player in playermanager
//get unitList from activeplayer
//if left was pressed -- in unit selection
//if right was pressed ++ in unit selection
//if confirm is pressed, change to activation phase and activate the unit at the selected index // code does not yet activate the unit



//rn, unitselection script is also unit activation script
public class UnitManagementScript
{

    PhaseManager phaseManager;
    PlayerManager playerManager;
    List<Units.Unit> unitList;

    private Units.Unit selectedUnit { get; set; }
    public Units.Unit SelectedUnit => selectedUnit;

    private int pendingIndex;

    public static UnitManagementScript unitManagement;

    public UnitManagementScript(PhaseManager phaseManager_, PlayerManager playerManager_)
    {
        pendingIndex = 0;
        Debug.Log(phaseManager_);

        init(phaseManager_, playerManager_);
        unitList = null;

    }
    void init(PhaseManager phaseManager_, PlayerManager playerManager_)
    {
        playerManager = playerManager_;
        phaseManager = phaseManager_;

    }
    public static void CreateUM(PhaseManager phaseManager, PlayerManager playerManager)
    {
        unitManagement = new(phaseManager, playerManager);

    }



    public void SelectUnit()
    {

        //FIXME - need to change this whenever we have a new player 

        unitList = playerManager.GetCurrentPlayersUnits();
    }

    public void PressLeft()
    {
        // in reality, this is a mock of the actual input
        if (pendingIndex <= 0)
        {
            pendingIndex = 0;
        }
        else
        {
            pendingIndex--;
        }
        Debug.Log(pendingIndex);
    }
    public void PressRight()
    {
        // in reality, this is a mock of the actual input
        if (pendingIndex >= unitList.Count() - 1)
        {
            pendingIndex = unitList.Count() - pendingIndex;
        }
        else
        {
            pendingIndex++;
        }
         

        Debug.Log(pendingIndex);
    }

    public Units.Unit PressConfirm()
    {
        phaseManager.ChangePhase(1);
        Debug.Log(phaseManager.GetCurrentPhase());
        Debug.Log(unitList[pendingIndex]);
        unitList[pendingIndex].ucomp.toggleactiveunit();
        return unitList[pendingIndex]; 
    }

 }



