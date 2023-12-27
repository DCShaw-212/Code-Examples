package com.company.weapon;

public class SuperShotgun extends Weapon{

    public SuperShotgun(){
        /**set the name of the weapon*/
        name = "Super Shotgun";

        /**Set the damage per shot of the super shotgun class*/
        setDamagePerShot(200);
        /**Set the ammo type used for super shotguns*/
        setAmmoTypeUsed(1);
        /**Set the ammount of ammo expended for the super shotgun per shot*/
        setAmmoExpended(2);
        /**Set the weapon index for the super shotgun*/
        setWeaponIndex(2);
    }
}
