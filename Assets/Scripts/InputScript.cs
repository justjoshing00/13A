using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script should start disabled in setup and be enabled when activated
// TODO: think about centralized control of input
public class InputScript
{
    MovementScript movementScript;
    ActionScript actionScript;

    public InputScript()
    {
        actionScript = new ActionScript();
        //movementScript = new MovementScript();
    }
    public void ExecuteUpdate(Units.Unit UnitToUpdate) // need to figure out how to move this specific unit
    {
                    
            if (Input.GetKeyDown(KeyCode.Space))
            {
            actionScript.SwitchMode();
            
            }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //change this to take LMB 
            actionScript.FirePrimaryWeapon();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //change this to take RMB
            actionScript.FireSecondaryWeapon();
        }
        //if (Input.GetKey(KeyCode.W)) //up
        //{
        //    movementScript.MoveUp();
        //}
        //if (Input.GetKey(KeyCode.S)) //down
        //{
        //    movementScript.MoveDown();
        //}
        //if (Input.GetKey(KeyCode.A)) //left
        //{
        //    movementScript.MoveLeft();
        //}
        //if (Input.GetKey(KeyCode.D)) //right
        //{
        //    movementScript.MoveRight();
        //}
        if (Input.GetKey(KeyCode.Tab))
        {
            Debug.Log("Objectives");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject.Find("phasemaanger").GetComponent<PhaseManager>().ChangePhase(0);  //bad for performance but it probably doesnt matter bc this is only going to be called once a turn 
            
            Debug.Log("end turn");
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Debug.Log("Strategic View");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //SendMessage("ChangeArmor");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("switch weapon");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("context specific action");
        }


    }
 
   


}
