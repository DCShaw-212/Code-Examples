package com.company.healthandarmor;

import com.company.player.Player;

/**Super/SubClass ArmorItem */
//Armor Items will add to armor but not exceed 100
class ArmorItem extends HealthOrArmorItem {

    //Data Members
    protected int armorAmount;

    //Functions
    /**This function adds armor */
//    public void addArmor(){
//        System.out.println(armorAmount + " armor added.");
//    }
    /**Get the armor amount*/
    public int getArmorAmount(){
        return armorAmount;
    }
    /**Set the armor amount*/
    public void setArmorAmount(int mail){
        this.armorAmount = mail;
    }

    /**pickUp Item - for Armor*/

    public boolean pickUpItem()
    {
        return player.addArmor(armorAmount);
    }
}
