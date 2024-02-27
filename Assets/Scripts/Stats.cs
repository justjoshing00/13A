using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Stats : MonoBehaviour
{
  // the problem is i dont need all the stats on all the things, so this is more like a namespace than
  // a class
  // yet there are cases where ill want to initiate all these at once
    struct BaseMovementStats
    {
        //dont change base stats directly after construction, instead modify them with another variable
        [SerializeField]
        float MovementBarValue;
        float baseMovementSpeed;

    }
   
}
