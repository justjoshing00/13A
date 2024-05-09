using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Units
{

    public class Unit
    {

        public UnitComponent ucomp;


        public Unit(in string Name, in int ID, in bool Active)
        {

            ucomp = new UnitComponent(Name, ID, Active);
        }

        public GameObject prefab;

    }



    public class UnitComponent
    {
        string unitName;
        public int unitID;
        private bool isActive { get; set; }
        public bool IsActive => isActive;





        public UnitComponent(in string unitname_, in int unitID_, in bool isActive_)
        {

            unitName = unitname_;
            unitID = unitID_;
            isActive = isActive_;
        }

        //omg bad name alert :getactiveunit, activeunit
       
        public void toggleactiveunit()
        {
            isActive = !isActive;
        }
        public void queryactive()
        {
            Debug.Log(isActive + " " + this);
        }
    };
    public class Mech : Unit
    {
        public Mech(in string Name, in int ID, in bool Active) : base(Name, ID, Active)
        {


        }
        
    }

    public class Soldier:Unit 
    {
       public Soldier(in string Name, in int ID, in bool Active) : base(in Name, in ID, in Active)
        {

        }

    }
    public class Autosoldier:Unit
    {
        public Autosoldier(in string Name, in int  ID, in bool Active) : base(in Name, in ID, in Active)
        {

        }
    }
    public class Drone:Unit
    {
        public Drone(in string Name, in int ID, in bool Active) : base(in Name, in ID, in Active)
        {

        }
    }
    public class Tank:Unit
    {
       public Tank(in string inName, in int ID, bool Active) : base(in inName, in ID, in Active)
        { 
        
        }
    }
    public class Artillery:Unit
    {
        public Artillery(in string Name, in int ID, in bool Active) : base(in Name, in ID, in Active)
        {

        }
    }

}