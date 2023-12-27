package com.company.healthandarmor;


/**Super/SubClass HealthItem */
//Health Items will add health but not exceed 100
public abstract class HealthItem extends HealthOrArmorItem {

    //DataMembers
    protected int healthAmount;

    //Functions
    /**This function adds health*/
//    // public void addHealth(){
//        System.out.println(healthAmount + " health added.");
//    }

    /**Get the health ammount*/
    public int getHealthAmount(){
        return healthAmount;
    }
    /**Set the health ammount*/
    public void setHealthAmount(int vitality){
        this.healthAmount = vitality;
    }

    public boolean pickUpItem(){
        return player.addHealth(healthAmount);
    }
}
