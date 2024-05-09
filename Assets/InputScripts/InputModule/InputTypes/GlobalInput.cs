using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInput:Input
{
    //system-level actions
    private CommandManager commandManager = new();
   
    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            commandManager.Pause();
        }
        
    }
}
