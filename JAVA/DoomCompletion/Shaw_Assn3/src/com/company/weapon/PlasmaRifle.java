package com.company.weapon;

public class PlasmaRifle extends Weapon{
    public PlasmaRifle(){
        /**set the name of the weapon*/
        name = "Plasma Rifle";

        /**Set the damage per shot of the plasma rifle class*/
        setDamagePerShot(200);
        /**Set the ammo type used for plasma rifle*/
        setAmmoTypeUsed(3);
        /**Set the ammount of ammo expended for the plasma rifle per shot*/
        setAmmoExpended(10);
        /**Set the weapon index for the plasma rifle*/
        setWeaponIndex(5);
    }
}
