using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSemesterLongAssignment
{
    public static class Calculations
    {
        public static int AggressiveEffectiveStrength(int strengthLevel)
        {
            int aggressive = 3;
            int effectiveStrength = strengthLevel + aggressive + 8;
            return effectiveStrength;
        }

        public static int ControlledEffectiveStrength(int strengthLevel)
        {
            int controlled = 1;
            int effectiveStrength = strengthLevel + controlled + 8;
            return effectiveStrength;
        }

        public static int AccurateOrDefensiveEffectiveStrength(int strengthLevel)
        {
            int effectiveStrength = strengthLevel + 8;
            return effectiveStrength;
        }

        public static int MaxHit(double effectiveStrength, int strengthBonus)
        {
            double maxhit = (0.5d + effectiveStrength * ((strengthBonus + 64d) / 640d));
            int intMaxhit = (int)Math.Round(maxhit);
            return intMaxhit;
        }




        public static int AccurateAttackLevel(int attackLevel)
        {
            return attackLevel + 11;
        }

        public static int ControlledAttackLevel(int attackLevel)
        {
            return attackLevel + 9;
        }
        public static int DefensiveOrAggressiveAttackLevel(int attackLevel)
        {
            return attackLevel;
        }
        public static int ToHitCalculation(int effectiveAttackLevel, int attackTypeAndBonus)
        {
            int attackToHitRoll = effectiveAttackLevel * (attackTypeAndBonus + 64);

            return attackToHitRoll;
        }

        public static int EnemyDefenseRoll(int enemyDefenceLevel, int defenceBonus)
        {
            int defenceToHitRoll = enemyDefenceLevel * (defenceBonus + 64);
            return defenceToHitRoll;
        }

        public static double CompareCombatRolls(double attackerRoll, double defenceRoll)
        {
            double finalToHitProbability;
            if(attackerRoll >= defenceRoll)
            {
                finalToHitProbability = 1d - 0.5d * defenceRoll / attackerRoll;
            }
            else
            {
                finalToHitProbability = 0.5d * attackerRoll / defenceRoll;
            }
            return finalToHitProbability;
        }


    }
}
