package com.company.weapon;

public class Shotgun extends Weapon {

    public Shotgun(){
        /**set the name of the weapon*/
        name = "Shotgun";

        /**Set the damage per shot of the shotgun class*/
        setDamagePerShot(70);
        /**Set the ammo type used for shotguns*/
        setAmmoTypeUsed(1);
        /**Set the ammount of ammo expended for the shotgun per shot*/
        setAmmoExpended(1);
        /**Set the weapon index for the shotgun*/
        setWeaponIndex(1);
    }
}
