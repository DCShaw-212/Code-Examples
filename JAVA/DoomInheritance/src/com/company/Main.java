//Assignment 2
//Purpose: Create classes and objects to represent health/armor items and ammo from Doom.




package com.company;

public class Main {

    public static void main(String[] args) {
        System.out.println("=====Testing Ammo=====");
        System.out.println("Testing AmmoItem");
        AmmoItem ammoitem = new AmmoItem();
        System.out.println(ammoitem.getName());
        ammoitem.addAmmo();
        System.out.println();

        System.out.println("Testing Clip");
        Clip clip = new Clip();
        System.out.println(clip.getName());
        clip.addAmmo();
        System.out.println();

        System.out.println("Testing BulletBox");
        BulletBox bulletbox = new BulletBox();
        System.out.println(bulletbox.getName());
        bulletbox.addAmmo();
        System.out.println();

        System.out.println("Testing ShellPack");
        ShellPack shellpack = new ShellPack();
        System.out.println(shellpack.getName());
        shellpack.addAmmo();
        System.out.println();

        System.out.println("Testing ShellBox");
        ShellBox shellbox = new ShellBox();
        System.out.println(shellbox.getName());
        shellbox.addAmmo();
        System.out.println();

        System.out.println("Testing Rocket");
        Rocket rocket = new Rocket();
        System.out.println(rocket.getName());
        rocket.addAmmo();
        System.out.println();

        System.out.println("Testing RocketBox");
        RocketBox rocketbox = new RocketBox();
        System.out.println(rocketbox.getName());
        rocketbox.addAmmo();
        System.out.println();

        System.out.println("Testing Cell");
        Cell cell = new Cell();
        System.out.println(cell.getName());
        cell.addAmmo();
        System.out.println();

        System.out.println("Testing CellPack");
        CellPack cellpack = new CellPack();
        System.out.println(cellpack.getName());
        cellpack.addAmmo();
        System.out.println();

        System.out.println("=====Testing HealthOrArmorItem=====");
        HealthOrArmorItem healthorarmoritem = new HealthOrArmorItem();
        System.out.println(healthorarmoritem.getName());
        System.out.println();

        System.out.println("=====Testing Health Items=====");
        System.out.println("Testing HealthItem");
        HealthItem healthitem = new HealthItem();
        System.out.println(healthitem.getName());
        healthitem.addHealth();
        System.out.println();

        System.out.println("Testing Stimpack");
        StimPack stimpack = new StimPack();
        System.out.println(stimpack.getName());
        stimpack.addHealth();
        System.out.println();

        System.out.println("Testing Stimpack");
        MedKit medkit = new MedKit();
        System.out.println(medkit.getName());
        medkit.addHealth();
        System.out.println();

        System.out.println("Testing HealthBonus");
        HealthBonus healthbonus = new HealthBonus();
        System.out.println(healthbonus.getName());
        healthbonus.addHealth();
        System.out.println();

        System.out.println("Testing SoulSphere");
        SoulSphere soulsphere = new SoulSphere();
        System.out.println(soulsphere.getName());
        soulsphere.addHealth();
        System.out.println();

        System.out.println("=====Testing Armor Items=====");
        System.out.println("Testing ArmorItem");
        ArmorItem armoritem = new ArmorItem();
        System.out.println(armoritem.getName());
        armoritem.addArmor();
        System.out.println();

        System.out.println("Testing ArmorBonus");
        ArmorBonus armorbonus = new ArmorBonus();
        System.out.println(armorbonus.getName());
        armorbonus.addArmor();
        System.out.println();

        System.out.println("Testing Armor");
        Armor armor = new Armor();
        System.out.println(armor.getName());
        armor.addArmor();
        System.out.println();

        System.out.println("Testing MegaArmor");
        MegaArmor megaarmor = new MegaArmor();
        System.out.println(megaarmor.getName());
        megaarmor.addArmor();
        System.out.println();

        System.out.println("Testing MegaSphere");
        MegaSphere megasphere = new MegaSphere();
        System.out.println(megasphere.getName());
        megasphere.addHealthAndArmor();
        System.out.println();
    }
}
