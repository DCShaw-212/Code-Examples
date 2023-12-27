package com.company;


/**Super/SubClass HealthItem */
//Health Items will add health but not exceed 100
class HealthItem extends HealthOrArmorItem{

    //DataMembers
    protected int healthAmount;

    //Functions
    /**This function adds health*/
    public void addHealth(){
        System.out.println(healthAmount + " health added.");
    }
}
