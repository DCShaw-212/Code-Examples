package com.company.healthandarmor;

import com.company.healthandarmor.HealthOrArmorItem;

/**Super/SubClass MegaSphere */
//MegaSpheres will add both armor and health
public class MegaSphere extends HealthOrArmorItem {

    //Data members
    protected int healthAmount;
    protected int armorAmount;

    //Constructor for MegaSphere
    public MegaSphere()
    {
        name = "Mega Sphere";
        healthAmount = 200;
        armorAmount = 200;
    }

    //Functions
    /** adds health and armor */
//    public void addHealthAndArmor(){
//        System.out.println(healthAmount + " health added.");
//        System.out.println(armorAmount + " armor added.");
//
//    }
    /**Get the healthAmount*/
    public int getHealthAmount(){
        return healthAmount;
    }
    /**Set the healthAmount*/
    public void setHealthAmount(int vitality){
        this.healthAmount = vitality;
    }

    /**Get the armorAmount*/
    public int getArmorAmount(){
        return armorAmount;
    }
    /**Set the armorAmount*/
    public void setArmorAmount(int plates){
        this.armorAmount = plates;
    }

    /**Pickup Item for MegaSphere*/
    public  boolean pickUpItem(){
           player.addHealth(healthAmount);
           player.addArmor(armorAmount);
          return true;
    };

}