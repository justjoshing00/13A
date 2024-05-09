using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierInput : UnitInput, IMovement,IAction,IInteraction
{
    public SoldierInput() : base()
    {

    }

    public void MoveUp(Units.Unit selectedunit)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            commandManager.MoveUp(selectedunit);

        }
    }
    public void MoveDown()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            commandManager.MoveDown();

        }
    }
    public void MoveLeft()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            commandManager.MoveLeft();

        }
    }
    public void MoveRight()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            commandManager.MoveRight();

        }
    }
    public void FirePrimary()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            commandManager.FirePrimary();
        }
    }
    public void FireSecondary()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            commandManager.FireSecondary();
        }
    }
    public void SwitchMode()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            commandManager.SwitchMode();
        }
    }
    public void ChangeArmor()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            commandManager.ChangeArmor();
        }
    }
    public void Interact()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            commandManager.Interact();
        }
    }
}

