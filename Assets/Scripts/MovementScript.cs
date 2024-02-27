using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    //keep in mind this is going to move into stats later
    float movementrange;
    float movementspeed;
    bool canmove;
    void Start()
    {
        movementrange = 10;
        movementspeed = 4;
        canmove = true;
    }
    
        public void MoveUp()
        {
            if (!canmove) return;
            print("Up");
            transform.position += movementspeed * Vector3.up * Time.deltaTime;
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
            print("Down");
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
            print("Left");
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
            print("Right");
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
    

            print("no remaining movement");
            //actually put something here that constrains movement

        
    }

}
