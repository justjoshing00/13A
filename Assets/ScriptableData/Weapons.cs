using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapons : ScriptableObject
{
    //TODO:rewrite this part to take values 
    Rifle rifle;
    Heavy_Rifle heavy_rifle;
    Camera camera;
    Main_Cannon main_cannon;
    Mortar mortar;
    TankBuster tankbuster;
    Railgun railgun;
    Missle_Battery missile_battery;

    List<Weapon> weaponlist;
    List<Weapon> initweapons(List<Weapon> weaponlist)
    {
        weaponlist.Add(rifle);
        weaponlist.Add(heavy_rifle);
        weaponlist.Add(camera);
        weaponlist.Add(main_cannon);
        weaponlist.Add(mortar);
        weaponlist.Add(tankbuster);
        weaponlist.Add(railgun);
        weaponlist.Add(missile_battery);
        return weaponlist;
    }

}



class Weapon
{
    
}

class Rifle : Weapon
{
    int WeaponPWR;
    Rifle(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }
}
class Heavy_Rifle : Weapon
{
    int WeaponPWR;
    Heavy_Rifle(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }
}
class Camera : Weapon
{
    int WeaponPWR;
    Camera(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }

}
class Main_Cannon:Weapon
{
    int WeaponPWR;
    Main_Cannon(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }

}
class Mortar : Weapon
{
    int WeaponPWR;
    Mortar(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }

}
class TankBuster:Weapon
{
    int WeaponPWR;
    TankBuster(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }
}

class Railgun : Weapon
{
    int WeaponPWR;
    Railgun(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }
}
class Missle_Battery : Weapon
{
    int WeaponPWR;
    Missle_Battery(int WeaponPWR_)
    {
        WeaponPWR = WeaponPWR_;
    }

}







//rifle
//heavy rifle
//camera
//main cannon
//mortar
//tankbuster
//anklebiter
//railgun
//missle battery
