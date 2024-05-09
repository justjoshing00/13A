using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : GlobalInput
{
    protected CommandManager commandManager;
    public PlayerInput()
    {
        commandManager = new();
    }


    //TODO: change name to 'move up list/move down list' or something 
    public void PressLeft()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            commandManager.PressLeft();
        }
    }
    public void PressRight()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            commandManager.PressRight();
        }
    }
    public Units.Unit Confirm()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            return commandManager.Confirm();
        }
        else
        {
            return null;
        }
    }
}
