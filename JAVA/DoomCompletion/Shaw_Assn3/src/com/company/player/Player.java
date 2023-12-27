package com.company.player;

import com.company.ammo.AmmoItem;
import com.company.healthandarmor.HealthItem;
import com.company.weapon.Weapon;
import com.company.healthandarmor.*;

public class Player {
    //Data members of the player class

    /**How much health the player has */
    protected int playerHealth = 100;
    /**How much armor the player has */
    protected int playerArmor;
    /**How much health the player can have */
    private int maxHealthPlayer;
    /**How much armor the player can have */
    private int maxArmorPlayer;

    /**Array to hold the ammount of ammo for each type*/
    private int [] ammoAmmountPerType = {50,0,0,0};

    /**Constant array that holds the max ammount of ammo of each type*/
    private final int[] maxAmmoArray = {200,50,50,300};

    /**Array of booleans that holds whether or not the player has each weapon*/
    private boolean[] hasWeaponsArray = {false,false,false,false,false,false,false};


    //Functions of the Player Class

    //2 printing methods
    /**Prints out the ammount of each ammo type*/
    public void printAmmo() {
        System.out.print("Ammo: ");
        for(int i = 0; i < ammoAmmountPerType.length;i++){
            System.out.print(ammoAmmountPerType[i] + " ");


        }
        System.out.println();
    }

    /**Prints out whether or not the player has each weapon*/
    public void printWeapons(){
        System.out.print("Weapons: ");

        for(int i = 0; i < hasWeaponsArray.length; i ++) {
            System.out.print(hasWeaponsArray[i] + " ");
        }
        System.out.println();
    }

    //3 methods to get attributes from the player

    /**getHealth - returns the players current health*/
    public int getHealth(){
        return playerHealth;
    }
    /**getArmor - returns the players current armor*/
    public int getArmor(){
        return playerArmor;
    }
    /**getAmmo -returns the amount of ammo the player has of indexed type specified*/
    public int getAmmo(int ammoCheck){
        return maxAmmoArray[ammoCheck];
    }

    //2 methods that affect the player's health and armor
    /**addHealth - adds health if health is needed*/
    public boolean addHealth(int amountHealthAdd){
        if(playerHealth < maxHealthPlayer)
        {
            playerHealth += amountHealthAdd;
            if(playerHealth > maxHealthPlayer)
            {
                playerHealth = maxHealthPlayer;

            }
            return true;
        }

        return false;


    }


    /**addArmor - adds armor if armor is needed*/

    public boolean addArmor(int amountArmorAdd){

        //if the armor was already maxed out then we still don't pick it up
       if(playerArmor < maxArmorPlayer){
           playerArmor+= amountArmorAdd;
           if(playerArmor > maxArmorPlayer){
               playerArmor = maxArmorPlayer;

           }
           return true;
       }
       return false;
    }
    //2 tricky methods addWeapon and addAmmo

    /**addWeapon - if the player does not have the weapon or if they aren't maxed out on its ammo type
     * set that they have the weapon to true
     */
    public boolean addWeapon(Weapon foundWeapon) {
        /**If they don't have the weapon pick it up or are not set at max ammo, add the ammo*/
        if (!hasWeaponsArray[Weapon.getWeaponIndex()] || !(maxAmmoArray[AmmoItem.getAmmoType()] <= AmmoItem.getAmmoAmount() + ammoAmmountPerType[AmmoItem.getAmmoType()])) {
            hasWeaponsArray[Weapon.getWeaponIndex()] = true;
            /**If you are at max ammo or adding enough to put you at max ammo*/
            if (maxAmmoArray[AmmoItem.getAmmoType()] <= AmmoItem.getAmmoAmount() + ammoAmmountPerType[AmmoItem.getAmmoType()]) {
                ammoAmmountPerType[AmmoItem.getAmmoType()] = maxAmmoArray[AmmoItem.getAmmoType()];
                return true;
            } else {
                ammoAmmountPerType[AmmoItem.getAmmoType()] += AmmoItem.getAmmoAmount();
                return true;
            }
        } else {
            return false;
        }
    }
    /**addAmmo - if the player isnt currently maxed out on the ammo type
     * add that much ammo to their stores, but make sure it doesn't go over max
     * return true if you can add ammo, return false if not
     */

    public boolean addAmmo(AmmoItem whichAmmo){
        /**Check if the ammo being added to current ammo is greater than max ammo*/
        /**If it is set maxAmmo to full*/
        /**If not then pick it up, return true*/
        if(ammoAmmountPerType[whichAmmo.getAmmoType()]< maxAmmoArray[whichAmmo.getAmmoType()])
        {
            ammoAmmountPerType[whichAmmo.getAmmoType()] += whichAmmo.getAmmoAmount();
            if(ammoAmmountPerType[whichAmmo.getAmmoType()] > maxAmmoArray[whichAmmo.getAmmoType()])
            {
                ammoAmmountPerType[whichAmmo.getAmmoType()] = maxAmmoArray[whichAmmo.getAmmoType()];
                return true;
            }
        }

        return false;


    }

}
