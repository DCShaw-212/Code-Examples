package com.company;

/** SuperClass AmmoItem */
public class AmmoItem {

    //Data members
    /**name of the Ammo item*/
    protected String name;
    /**Holds the type of ammo*/
    protected String ammoType;
    /**Holds the amount of ammo the item would grant when picking it up*/
    protected int ammoAmount;

    //functions

    /**gets the name of the ammo item*/
    public String getName()
    {
        return name;
    }

    /**Will eventually add ammo but for now just prints out how much is being added and of what type */
    public void addAmmo()
    {
        System.out.println("Ammo type added: " + ammoType);
        System.out.println("Ammo amount being added: " + ammoAmount);
    }
}





