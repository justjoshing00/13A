using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionScript
{
    private bool mode;
    public static ActionScript actionScript;
    public ActionScript()
    {
        mode = false; // boolean represents platform/mobile modes

    }
    public static void CreateAS()
    {
        actionScript = new();
    }
    public void SwitchMode()
    {
        mode = !mode;
        Debug.Log(mode);
    }

public void FirePrimaryWeapon()
{

    if (mode == false)
    {
        Debug.Log("Primary mobile fire");
    }
    else
    {
        Debug.Log("Primary platform fire");
    }
}
public void FireSecondaryWeapon()
{

    if (mode == false)
    {
        Debug.Log("Secondary mobile fire");
    }
    else
    {
        Debug.Log("Secondary platform fire");
    }
}
}
