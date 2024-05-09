using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovement
{
    public void MoveUp(Units.Unit selectedunit)
    {
        Debug.Log("word up");
    }
   
    public void MoveDown()
    {
        Debug.Log("word down");
    }
    public void MoveLeft()
    {
        Debug.Log("word left");
    }
    public void MoveRight()
    {
        Debug.Log("word right");
    }
    

    
}
