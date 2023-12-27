package com.company.weapon;

import com.company.Item.Item;

public abstract class Weapon extends Item {


    //Data members

    /**How much damage done per shot*/
    protected int damagePerShot;
    /**How much ammo used per shot*/
    protected int ammoExpended;
    /**Ammo type that the weapon uses*/
    protected int ammoTypeUsed;
    /**Weapon Index*/
    private static int weaponIndex;


    //Setters and getters

    /**Gets the damage per shot*/
    public int getDamage(){
        return damagePerShot;
    }
    /**Sets the damage per shot*/
    public void setDamagePerShot(int damage){
        this.damagePerShot = damage;
    }

    /**Gets the ammo used per shot*/
    public int getAmmoPerShot(){
        return ammoExpended;
    }
    /**Sets the ammo used per shot*/
    public void setAmmoExpended(int ammoSpent){
        this.ammoExpended = ammoSpent;
    }

    /**Gets the ammo type shot*/
    public int getAmmoType(){
        return ammoTypeUsed;
    }
    /**Sets the ammo type shot*/
    public void setAmmoTypeUsed(int ammoUsed){
        this.ammoTypeUsed = ammoUsed;
    }

    /**Gets the weapon index*/
    public static int getWeaponIndex(){
        return weaponIndex;
    }
    /**Sets the weapon index*/
    public void setWeaponIndex(int weaponInd){
        this.weaponIndex = weaponInd;
    }

    /**Picks up a weapon for the player*/

    public boolean pickUpItem(){
        return player.addWeapon(Weapon.this);
    }

}
