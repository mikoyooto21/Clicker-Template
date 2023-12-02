using System;
public static class Upgrades
{    
    public static double PriceIncreaser(double price, double upgradesAmount){
        return Math.Round(price * Math.Pow(1.055, upgradesAmount), 2);
    }

    public static double AttackIncreaser(double attack, double upgradesAmount){
        return Math.Round(attack * Math.Pow(1.04, upgradesAmount), 2);
    }
}
