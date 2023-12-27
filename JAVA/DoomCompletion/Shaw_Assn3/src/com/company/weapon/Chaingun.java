package com.company.weapon;

public class Chaingun extends Weapon{
    public Chaingun(){
        /**set the name of the weapon*/
        name = "Chain Gun";
        /**Set the damage per shot of the chaingun class*/
        setDamagePerShot(200);
        /**Set the ammo type used for chainguns*/
        setAmmoTypeUsed(0);
        /**Set the ammount of ammo expended for the chaingun per shot*/
        setAmmoExpended(20);
        /**Set the weapon index for the chaingun*/
        setWeaponIndex(3);
    }
}
