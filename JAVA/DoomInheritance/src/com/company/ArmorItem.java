package com.company;

/**Super/SubClass ArmorItem */
//Armor Items will add to armor but not exceed 100
class ArmorItem extends HealthOrArmorItem{

    //Data Members
    protected int armorAmount;

    //Functions
    /**This function adds armor */
    public void addArmor(){
        System.out.println(armorAmount + " armor added.");
    }
}
