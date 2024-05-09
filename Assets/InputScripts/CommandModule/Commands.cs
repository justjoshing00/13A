using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//actionscript, movementscript,and unitmanagementscript prolly have to be instanced here


public class Commands
{
    
   
    public Commands()
    {
         
    }

    public void MoveUp(Units.Unit selectedunit)
    {
        Debug.Log("moved up");
        MovementScript.movementScript.MoveUp(selectedunit);

    }
    public void MoveDown()
    {
        Debug.Log("moved down");
    }
    public void MoveLeft()
    {
        Debug.Log("moved left");
    }
    public void MoveRight()
    {
        Debug.Log("moved right");
    }
    public void FirePrimary()
    {
        Debug.Log("Primary weapon fired");
        ActionScript.actionScript.FirePrimaryWeapon();
    }
    public void FireSecondary()
    {
        Debug.Log("Secondary weapon fired");
        ActionScript.actionScript.FireSecondaryWeapon();
    }
    public void SwitchMode()
    {
        Debug.Log("mode switched");
        ActionScript.actionScript.SwitchMode();
    }
    public void ChangeArmor()
    {
        Debug.Log("armortype changed");
    }
    public void Interact()
    {
        Debug.Log("interacted with gameobject");
    }
    public void EndTurn()
    {
        Debug.Log("turn ended");
    }
    public void ViewObjectives()
    {
        Debug.Log("opened objectives screen");
    }
    public void Pause()
    {
        Debug.Log("game paused");
    }
    public void PressLeft()
    {
        Debug.Log("moved up the list of units");
        UnitManagementScript.unitManagement.PressLeft();
    }
    public void PressRight()
    {
        Debug.Log("moved down the list of units");
        UnitManagementScript.unitManagement.PressRight();
    }
    public Units.Unit Confirm()
    {
        Debug.Log("unit selected");
        return UnitManagementScript.unitManagement.PressConfirm(); //so I need to give this to gameloop, somehow
    }

}
