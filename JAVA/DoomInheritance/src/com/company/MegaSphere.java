package com.company;

/**Super/SubClass MegaSphere */
//MegaSpheres will add both armor and health
class MegaSphere extends HealthOrArmorItem{

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
    public void addHealthAndArmor(){
        System.out.println(healthAmount + " health added.");
        System.out.println(armorAmount + " armor added.");

    }
}