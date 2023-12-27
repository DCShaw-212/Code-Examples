package com.company;

import com.company.ammo.*;
import com.company.healthandarmor.*;
import com.company.player.Player;
import com.company.weapon.*;

public class Main {

    public static void main(String[] args) {

        Player testPlayer = new Player();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        testPlayer.printWeapons();
        testPlayer.printAmmo();
        System.out.println("Individual Ammo");
        System.out.println( testPlayer.getAmmo(0) + " " + testPlayer.getAmmo(1) + " " +
                testPlayer.getAmmo(1) + " " + testPlayer.getAmmo(2));

        System.out.println("Testing Weapons");
        Pistol pistol = new Pistol();
        pistol.setPlayer(testPlayer);
        pistol.pickUpItem();

        testPlayer.printWeapons();

        Shotgun shotgun = new Shotgun();
        shotgun.setPlayer(testPlayer);
        shotgun.pickUpItem();

        testPlayer.printWeapons();

        SuperShotgun ssg = new SuperShotgun();
        ssg.setPlayer(testPlayer);
        ssg.pickUpItem();

        testPlayer.printWeapons();

        Chaingun chaingun = new Chaingun();
        chaingun.setPlayer(testPlayer);
        chaingun.pickUpItem();

        testPlayer.printWeapons();

        RocketLauncher rl = new RocketLauncher();
        rl.setPlayer(testPlayer);
        rl.pickUpItem();

        testPlayer.printWeapons();

        PlasmaRifle pr = new PlasmaRifle();
        pr.setPlayer(testPlayer);
        pr.pickUpItem();

        testPlayer.printWeapons();

        BFG9000 bfg = new BFG9000();
        bfg.setPlayer(testPlayer);
        bfg.pickUpItem();

        testPlayer.printWeapons();

        System.out.println("Should be true, still space for ammo!");
        BFG9000 bfg2 = new BFG9000();
        bfg2.setPlayer(testPlayer);
        System.out.println("Was able to pick up a second BFG? " + bfg2.pickUpItem());

        System.out.println();
        System.out.println("=====Testing Ammo=====");

        Clip clip = new Clip();
        clip.setPlayer(testPlayer);
        clip.pickUpItem();

        testPlayer.printAmmo();

        BulletBox bulletbox = new BulletBox();
        bulletbox.setPlayer(testPlayer);
        bulletbox.pickUpItem();

        testPlayer.printAmmo();

        ShellPack shells = new ShellPack();
        shells.setPlayer(testPlayer);
        shells.pickUpItem();

         testPlayer.printAmmo();

        ShellBox shellbox = new ShellBox();
        shellbox.setPlayer(testPlayer);
        shellbox.pickUpItem();

        testPlayer.printAmmo();

        Rocket rocket = new Rocket();
        rocket.setPlayer(testPlayer);
        rocket.pickUpItem();

        testPlayer.printAmmo();

        RocketBox rocketbox = new RocketBox();
        rocketbox.setPlayer(testPlayer);
        rocketbox.pickUpItem();

       testPlayer.printAmmo();

        Cell cell = new Cell();
        cell.setPlayer(testPlayer);
        cell.pickUpItem();

        testPlayer.printAmmo();

        CellPack cellpack = new CellPack();
        cellpack.setPlayer(testPlayer);
        cellpack.pickUpItem();

        testPlayer.printAmmo();

        System.out.println("Adding 3 more cell packs to make sure we can't go over max:");
        CellPack cellpack2 = new CellPack();
        cellpack2.setPlayer(testPlayer);
        cellpack2.pickUpItem();

        CellPack cellpack3 = new CellPack();
        cellpack3.setPlayer(testPlayer);
        cellpack3.pickUpItem();

        CellPack cellpack4 = new CellPack();
        cellpack4.setPlayer(testPlayer);
        cellpack4.pickUpItem();

        testPlayer.printAmmo();

        System.out.print("Cells are now full... can we get a third BFG? ");
        BFG9000 bfg3 = new BFG9000();
        bfg3.setPlayer(testPlayer);
        System.out.println(bfg3.pickUpItem());

        System.out.println();

        System.out.println("=====Testing Health=====");

        StimPack stimpack = new StimPack();
        stimpack.setPlayer(testPlayer);
        stimpack.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        MedKit medkit = new MedKit();
        medkit.setPlayer(testPlayer);
        medkit.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        HealthBonus healthbonus = new HealthBonus();
        healthbonus.setPlayer(testPlayer);
        healthbonus.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        SoulSphere soulsphere = new SoulSphere();
        soulsphere.setPlayer(testPlayer);
        soulsphere.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        System.out.println("=====Testing Armor Items=====");
        Armor armor = new Armor();
        armor.setPlayer(testPlayer);
        armor.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        ArmorBonus armorbonus = new ArmorBonus();
        armorbonus.setPlayer(testPlayer);
        armorbonus.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        MegaArmor megaarmor = new MegaArmor();
        megaarmor.setPlayer(testPlayer);
        megaarmor.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        System.out.println("Armor should still be 200");
        ArmorBonus armorbonus2 = new ArmorBonus();
        armorbonus2.setPlayer(testPlayer);
        armorbonus2.pickUpItem();

        System.out.println("Health: " + testPlayer.getHealth());
        System.out.println("Armor: " + testPlayer.getArmor());
        System.out.println();

        //Test Megasphere with new player:
        Player testPlayer2 = new Player();
        System.out.println("Health: " + testPlayer2.getHealth());
        System.out.println("Armor: " + testPlayer2.getArmor());
        System.out.println();

        MegaSphere megasphere = new MegaSphere();
        megasphere.setPlayer(testPlayer2);
        megasphere.pickUpItem();
        System.out.println("Health: " + testPlayer2.getHealth());
        System.out.println("Armor: " + testPlayer2.getArmor());
        System.out.println();

        System.out.println("Testing Weapons More in Depth");
        System.out.println("Weapon: " + pistol.getName());
        System.out.println("Damage: " + pistol.getDamage());
        System.out.println("Ammo Type: " + pistol.getAmmoType());
        System.out.println("Ammo Per Shot: "  + pistol.getAmmoPerShot());
        System.out.println();

        System.out.println("Weapon: " + shotgun.getName());
        System.out.println("Damage: " + shotgun.getDamage());
        System.out.println("Ammo Type: " + shotgun.getAmmoType());
        System.out.println("Ammo Per Shot: "  + shotgun.getAmmoPerShot());
        System.out.println();

        System.out.println("Weapon: " + ssg.getName());
        System.out.println("Damage: " + ssg.getDamage());
        System.out.println("Ammo Type: " + ssg.getAmmoType());
        System.out.println("Ammo Per Shot: "  + ssg.getAmmoPerShot());
        System.out.println();

        System.out.println("Weapon: " + chaingun.getName());
        System.out.println("Damage: " + chaingun.getDamage());
        System.out.println("Ammo Type: " + chaingun.getAmmoType());
        System.out.println("Ammo Per Shot: "  + chaingun.getAmmoPerShot());
        System.out.println();

        System.out.println("Weapon: " + rl.getName());
        System.out.println("Damage: " + rl.getDamage());
        System.out.println("Ammo Type: " + rl.getAmmoType());
        System.out.println("Ammo Per Shot: "  + rl.getAmmoPerShot());
        System.out.println();

        System.out.println("Weapon: " + pr.getName());
        System.out.println("Damage: " + pr.getDamage());
        System.out.println("Ammo Type: " + pr.getAmmoType());
        System.out.println("Ammo Per Shot: "  + pr.getAmmoPerShot());
        System.out.println();

        System.out.println("Weapon: " + bfg.getName());
        System.out.println("Damage: " + bfg.getDamage());
        System.out.println("Ammo Type: " + bfg.getAmmoType());
        System.out.println("Ammo Per Shot: "  + bfg.getAmmoPerShot());
    }


}
