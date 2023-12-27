package com.company.Item;

import com.company.player.Player;

public abstract class Item {

     //datamembers
    /**name of the item*/
    protected String name;
    protected Player player;



    //methods
    /**gets the name of the ammo item*/
    public String getName() {
        return name;
    }
    /**sets the player*/
    public void setPlayer(Player player1){
        player = player1;
    }

    /**pickUpItem() - is the item picked up*/
    public abstract boolean pickUpItem();




}
