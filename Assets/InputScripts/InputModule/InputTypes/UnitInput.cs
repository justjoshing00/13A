using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitInput: GlobalInput
{
    //end turn, objectives screen, etc
    //I want to be able to compose the input classes from a bunch of interfaces
    protected CommandManager commandManager;

    protected UnitInput()
    {
        commandManager = new();
    }

    public void EndTurn()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            commandManager.EndTurn();
        }
    }
    public void ViewObjectives()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            commandManager.ViewObjectives();
        }
    }
}
