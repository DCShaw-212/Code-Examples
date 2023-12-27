package com.company.weapon;

public class BFG9000 extends Weapon{
    public BFG9000(){
        /**set the name of the weapon*/
        name = "BFG9000";
        /**Set the damage per shot of the BFG class*/
        setDamagePerShot(500);
        /**Set the ammo type used for BFGs*/
        setAmmoTypeUsed(3);
        /**Set the ammount of ammo expended for the BFG per shot*/
        setAmmoExpended(40);
        /**Set the weapon index for the BFG*/
        setWeaponIndex(6);
    }

    @Override
    public boolean pickUpItem() {
        return false;
    }
}
