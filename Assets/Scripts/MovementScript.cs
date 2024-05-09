using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : Transform
{
    //keep in mind this is going to move into stats later
    float movementrange;
    float movementspeed;
    bool canmove;

    public static MovementScript movementScript;
    void Start()
    {
        movementrange = 10;
        movementspeed = 4;
        canmove = true;
    }

    public static void CreateMS()
    {
        movementScript = new();
    }


    public void MoveUp(Units.Unit selectedunit)
        {
            if (!canmove) return;
            Debug.Log("Up");
            selectedunit.prefab.transform.position += movementspeed * Vector3.up * Time.deltaTime;
            if (transform.position.y >= Mathf.Abs(movementrange))
        {

            //print(FindRemainingMovement());
            CannotMove();
            canmove = false;
        }

    }
        public void MoveDown()
        {
            if (!canmove) return;
            Debug.Log("Down");
            transform.position += movementspeed * Vector3.down * Time.deltaTime;
            if (transform.position.y <= Mathf.Abs(movementrange))
            {
            
                //print(FindRemainingMovement());
                CannotMove();
                canmove = false;
            }
        }
        public void MoveLeft()
        {
            if (!canmove) return;
            Debug.Log("Left");
            transform.position += movementspeed * Vector3.left * Time.deltaTime;
            if (transform.position.x <= Mathf.Abs(movementrange))
            {
                canmove = false;
                //print(FindRemainingMovement());
                CannotMove();
            }
        }
        public void MoveRight()
        {
            if (!canmove) return;
            Debug.Log("Right");
            transform.position += movementspeed * Vector3.right * Time.deltaTime;
            if (transform.position.x >= Mathf.Abs(movementrange))
            {
                
                //print(FindRemainingMovement());
                CannotMove();
            }
        }
    
    float FindRemainingMovement()
    {
        movementrange -= movementspeed;
        return movementrange;
    }
    void CannotMove()
    {
    

            Debug.Log("no remaining movement");
            //actually put something here that constrains movement

        
    }

}
