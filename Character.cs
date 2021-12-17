using System;

namespace OOPSemesterLongAssignment.Character
{
    public class NewCharacter : Character
    {
        public NewCharacter()
        {

        }

        public override string EquipmentType
        {
            get => equipmentSlot;
            set => equipmentSlot = value;
        }

        public override int AttStab()
        {
            return 0;
        }
        public override int AttSlash()
        {
            return 0;
        }
        public override int AttCrush()
        {
            return  0;
        }
        public override int AttMagic()
        {
            return 0;
        }
        public override int AttRanged()
        {
            return 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return 0;
        }
        public override int DefSlash()
        {
            return 0;
        }
        public override int DefCrush()
        {
            return 0;
        }
        public override int DefMagic()
        {
            return 0;
        }
        public override int DefRanged()
        {
            return 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return 0;
        }
        public override int RangedStrength()
        {
            return 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return 0;
        }
    }
    public enum EquipmentSlot
    {
        Head,
        Chest,
        Hands,
        Legs,
        Feet,
        Cape,
        Ring, 
        Neck, 
        Weapon, 
        Offhand, 
        Ammunition
    }
    //utilizing a decorator design pattern to accumulate equipment bonuses
    //all equipment types have the potential of all of these values, some will have positiive bonuses to certain stats and negative bonuses to certain stats and some will stay 0
    public abstract class Character
    {
        public string equipmentSlot;
        public int attackLevel = 1;
        public int defenceLevel = 1;
        public int strengthLevel = 1;
        public int magicLevel = 1;
        public int rangedLevel = 1;
        public int prayerLevel = 1;

        public Character()
        {
            AttackLevel = attackLevel;
            StrengthLevel = strengthLevel;
            DefenceLevel = defenceLevel;
            RangedLevel = rangedLevel;
            MagicLevel = magicLevel;
            PrayerLevel = prayerLevel;
        }


        public int AttackLevel
        {
            get => attackLevel;
            set
            {
                if ((value >= 1) && (value <= 99))
                {
                    attackLevel = value;
                }
            }
        }
        public int StrengthLevel
        {
            get => strengthLevel;
            set
            {
                if ((value >= 1) && (value <= 99))
                {
                    strengthLevel = value;
                }
            }
        }
        public int DefenceLevel
        {
            get => defenceLevel;
            set
            {
                if ((value >= 1) && (value <= 99))
                {
                    defenceLevel = value;
                }
            }
        }
        public int RangedLevel
        {
            get => rangedLevel;
            set
            {
                if ((value >= 1) && (value <= 99))
                {
                    rangedLevel = value;
                }
            }
        }
        public int MagicLevel
        {
            get => magicLevel;
            set
            {
                if ((value >= 1) && (value <= 99))
                {
                    magicLevel = value;
                }
            }
        }
        public int PrayerLevel
        {
            get => prayerLevel;
            set
            {
                if ((value >= 1) && (value <= 99))
                {
                    prayerLevel = value;
                }
            }
        }

        public Character[] characters = new Character[11];

        public abstract string EquipmentType
        {
            get; set;
        }
        //attack bonuses 
        public abstract int AttStab();
        public abstract int AttSlash();
        public abstract int AttCrush();
        public abstract int AttMagic();
        public abstract int AttRanged();

        //defence bonuses
        public abstract int DefStab();
        public abstract int DefSlash();
        public abstract int DefCrush();
        public abstract int DefMagic();
        public abstract int DefRanged();

        //other bonuses
        public abstract int MeleeStrength();
        public abstract int RangedStrength();
        public abstract int MagicStrength(); //percentage boost
        public abstract int Prayer(); //used to calculate the prayer drain rate
    }

    public abstract class EquipmentDecorator : Character
    {
        public override abstract string EquipmentType
        { get; set; }

        //attack bonuses 
        public override abstract int AttStab();
        public override abstract int AttSlash();
        public override abstract int AttCrush();
        public override abstract int AttMagic();
        public override abstract int AttRanged();

        //defence bonuses
        public override abstract int DefStab();
        public override abstract int DefSlash();
        public override abstract int DefCrush();
        public override abstract int DefMagic();
        public override abstract int DefRanged();

        //other bonuses
        public override abstract int MeleeStrength();
        public override abstract int RangedStrength();
        public override abstract int MagicStrength(); //percentage boost
        public override abstract int Prayer(); //used to calculate the prayer drain rate
    }

    //equipment
    public class NoHelmet : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Head;

        public NoHelmet(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Head);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class HelmOfNeitiznot : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Head;

        public HelmOfNeitiznot(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Head);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }
        
        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 31;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 29;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 34;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 3;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 30;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 3;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 3;
        }
    }
    public class NeitiznotFaceguard : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Head;

        public NeitiznotFaceguard(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Head);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 36;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 34;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 38;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 3;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 34;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 6;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 3;
        }
    }
    public class NoChestArmor : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Chest;

        public NoChestArmor(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Chest);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class BandosChestplate : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Chest;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Chest);
            }
        }
        Character character;

        public BandosChestplate(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() - 15;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() - 10;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 98;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 93;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 105;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() - 6;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() +133;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 4;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 1;
        }
    }
    public class NoGloves : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Hands;

        public NoGloves(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Hands);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class BarrowsGloves : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Hands;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Hands);
            }
        }
        Character character;

        public BarrowsGloves(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 12;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 12;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 12;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 6;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 12;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 12;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 12;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 12;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 6;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 12;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 12;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class NoLegArmor : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Legs;

        public NoLegArmor(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Legs);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class BandosTassets : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Legs;
        Character character;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Legs);
            }
        }
        public BandosTassets(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() - 21;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() - 7;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 71;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 63;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 66;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() - 4;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 93;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 2;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 1;
        }
    }
    public class NoBoots : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Feet;

        public NoBoots(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Feet);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class PrimordialBoots : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Feet; 
        Character character;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Feet);
            }
        }
        public PrimordialBoots(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 2;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 2;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 2;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() - 4;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() - 1;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 22;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 22;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 22;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 5;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class NoCape : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Cape;

        public NoCape(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Cape);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class InfernalCape : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Cape;
        Character character;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Cape);
            }
        }
        public InfernalCape(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 4;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 4;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 4;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 1;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 1;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 12;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 12;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 12;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 12;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 12;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 8;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 2;
        }
    }
    public class NoRing : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Ring;

        public NoRing(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Ring);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class ImbuedBerserkerRing : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Ring;
        Character character; 
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Ring);
            }
        }
        public ImbuedBerserkerRing(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 8;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 8;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class NoAmulet : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Neck;

        public NoAmulet(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Neck);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class AmuletOfTorture : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Neck;
        Character character;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Neck);
            }
        }
        public AmuletOfTorture(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 15;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 15;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 15;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 10;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 2;
        }
    }
    public class Unarmed : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Weapon;

        public Unarmed(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Weapon);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class AbyssalWhip : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Weapon;
        Character character;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Weapon);
            }
        }

        public AbyssalWhip(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 82;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 82;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 2;
        }
    }
    public class NoOffhand : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Offhand;

        public NoOffhand(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Offhand);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class DragonDefender : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Offhand;
        Character character;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Offhand);
            }
        }

        public DragonDefender(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 25;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 24;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 23;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() - 3;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() - 2;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 25;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 24;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 23;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() - 3;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() - 2;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 6;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class NoAmmunitionSlotItem : EquipmentDecorator
    {
        Character character;

        public static EquipmentSlot slot = EquipmentSlot.Ammunition;

        public NoAmmunitionSlotItem(Character character)
        {
            this.character = character;
            this.character.characters[0] = this;
            equipmentSlot = Convert.ToString(EquipmentSlot.Ammunition);

        }

        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = value;
            }
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 0;
        }
    }
    public class HolyBlessing : EquipmentDecorator
    {
        public static EquipmentSlot slot = EquipmentSlot.Ammunition;
        Character character;
        public override string EquipmentType
        {
            get => this.character.equipmentSlot;
            set
            {
                equipmentSlot = Convert.ToString(EquipmentSlot.Ammunition);
            }
        }

        public HolyBlessing(Character character)
        {
            this.character = character;
        }

        public override int AttStab()
        {
            return this.character.AttStab() + 0;
        }
        public override int AttSlash()
        {
            return this.character.AttSlash() + 0;
        }
        public override int AttCrush()
        {
            return this.character.AttCrush() + 0;
        }
        public override int AttMagic()
        {
            return this.character.AttMagic() + 0;
        }
        public override int AttRanged()
        {
            return this.character.AttRanged() + 0;
        }

        //defence bonuses
        public override int DefStab()
        {
            return this.character.DefStab() + 0;
        }
        public override int DefSlash()
        {
            return this.character.DefSlash() + 0;
        }
        public override int DefCrush()
        {
            return this.character.DefCrush() + 0;
        }
        public override int DefMagic()
        {
            return this.character.DefMagic() + 0;
        }
        public override int DefRanged()
        {
            return this.character.DefRanged() + 0;
        }

        //other bonuses
        public override int MeleeStrength()
        {
            return this.character.MeleeStrength() + 0;
        }
        public override int RangedStrength()
        {
            return this.character.RangedStrength() + 0;
        }
        //percentage boost
        public override int MagicStrength()
        {
            return this.character.MagicStrength() + 0;
        }
        //used to calculate the prayer drain rate
        public override int Prayer()
        {
            return this.character.Prayer() + 1;
        }
    }

    //equipment factory does all the addition of the items I'll be using for the calculation
    public static class EquipmentFactory
    {
        public static Character Create(string[] equipment)
        {
            Character character = new NewCharacter();
            foreach(string item in equipment)
            {
                Type T = Type.GetType("OOPSemesterLongAssignment.Character." + item);
                character = (Character)Activator.CreateInstance(T, new Object[] { character });
            }
            return character;
        }
    }
}