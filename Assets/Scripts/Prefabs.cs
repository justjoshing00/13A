using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Prefabs : ScriptableObject
{
    [SerializeField] GameObject Mech;
    GameObject mechinstance { get; set; }
    public GameObject MechInstance => mechinstance;
    public void SetupMech(Vector3 intpos)
    {

        mechinstance = Instantiate(Mech);
    }


    [SerializeField] GameObject Tank;
    GameObject tankinstance { get; set; }
    public GameObject TankInstance => tankinstance;
    public void SetupTank(Vector3 intpos)
    {

        tankinstance = Instantiate(Tank);
    }


    [SerializeField] GameObject Soldier;
    GameObject soldierinstance { get; set; }
    public GameObject SoldierInstance => soldierinstance;
    public void SetupSoldier(Vector3 intpos)
    {

        mechinstance = Instantiate(Soldier);
    }

   //solving this bug:
   //i can create a  

}
