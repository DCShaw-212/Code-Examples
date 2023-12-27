package com.company.weapon;

public class Pistol extends Weapon{

    public Pistol(){
        /**set the name of the weapon*/
        name = "Pistol";

        /**Set the damage per shot of the pistol class*/
        setDamagePerShot(10);
        /**Set the ammo type used for pistols*/
        setAmmoTypeUsed(0);
        /**Set the ammount of ammo expended for the pistol per shot*/
        setAmmoExpended(1);
        /**Set the weapon index for the pistol*/
        setWeaponIndex(0);

    }
}
