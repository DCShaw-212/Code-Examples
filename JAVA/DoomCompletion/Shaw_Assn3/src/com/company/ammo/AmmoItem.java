package com.company.ammo;

import com.company.Item.Item;

/** SuperClass AmmoItem */
public class AmmoItem extends Item {

    //Data members
    /**name of the Ammo item*/
    protected String name;
    /**Holds the type of ammo*/
    protected static int ammoType;
    /**Holds the amount of ammo the item would grant when picking it up*/
    protected static int ammoAmount;


    //functions

    /**Will eventually add ammo but for now just prints out how much is being added and of what type */
//    public void addAmmo()
//    {
//        System.out.println("Ammo type added: " + ammoType);
//        System.out.println("Ammo amount being added: " + ammoAmount);
//    }
     /**Get the ammoType*/
      public static int getAmmoType(){
             return ammoType;
      }

      /**Set the ammoType*/
      public void setAmmoType(int roundType){
          this.ammoType = roundType;
      }

      /**Get the ammoAmount*/
      public static int getAmmoAmount(){
          return ammoAmount;
      }
      /**Set the ammoAmount*/
      public void setAmmoAmount( int numOfRounds){
          this.ammoAmount = numOfRounds;
      }

      /**Picks up ammo for the player*/
      public boolean pickUpItem(){
          return player.addAmmo(this);
      }

}





