package com.company.weapon;

public class RocketLauncher extends Weapon{
    public RocketLauncher(){
        /**set the name of the weapon*/
        name = "Rocket Launcher";

        /**Set the damage per shot of the RocketLauncher class*/
        setDamagePerShot(90);
        /**Set the ammo type used for RocketLaunchers*/
        setAmmoTypeUsed(2);
        /**Set the ammount of ammo expended for the Rocket Launcher per shot*/
        setAmmoExpended(1);
        /**Set the weapon index for the Rocket Launcher*/
        setWeaponIndex(4);
    }
}
