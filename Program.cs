using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OOPSemesterLongAssignment.Character;

namespace OOPSemesterLongAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int enemyDefenceLevel = 0;
            int enemyDefenceBonus = 0;

            while (true)
            {
                //Prompt user for levels
                Console.Write("Enter your attack level: ");
                int attackLevel = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your strength level: ");
                int strengthLevel = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your defence level: ");
                int defenceLevel = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your ranged level: ");
                int rangedLevel = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your magic level: ");
                int magicLevel = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your prayer level: ");
                int prayerLevel = Convert.ToInt32(Console.ReadLine());

                //prompt users for creature stats
                var enemies = new List<Enemy>();
                if (File.Exists(@"OSRSEnemies.json"))
                    enemies = JsonConvert.DeserializeObject<List<Enemy>>(File.ReadAllText(@"OSRSEnemies.json"));

                Console.Clear();
                Console.WriteLine("Would you like to save new enemy stats or select one that's already been entered? ");
                Console.WriteLine("1. List the currently saved enemies");
                Console.WriteLine("2. Save a new enemy");
                int.TryParse(Console.ReadLine(), out var choice);
                int selection = 0;
                Console.Clear();
                if (choice == 1)
                {
                    if (enemies.Count > 0)
                    {
                        int counter = 1;
                        //list the currently saved enemies 
                        foreach (var enemy in enemies)
                        {
                            Console.WriteLine($"{counter}: \t" + enemy.Name);
                            counter++;
                        }

                        Console.Write("Select an enemy using the number associated with it: ");
                        selection = Convert.ToInt32(Console.ReadLine());
                        selection -= 1;
                        Console.WriteLine($"You've selected the {enemies[selection].Name}! Its stats will be used for the calculation. ");
                        enemyDefenceLevel = enemies[selection].DefenceLevel;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you have not input any enemies yet.");
                        Console.WriteLine("Exiting the program, press any button to continue");
                        Console.ReadLine();
                        break;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("all creature information is available at \thttps://oldschool.runescape.wiki/\n");
                    Console.Write("What is the creatures name: ");
                    string name = Console.ReadLine();
                    Console.Write("What is the creatures defence level? ");
                    enemyDefenceLevel = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the creatures stab defence stat? ");
                    int stabDefence = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the creatures slash defence stat? ");
                    int slashDefence = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the creatures crush defence stat? ");
                    int crushDefence = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the creatures magic defence stat? ");
                    int magicDefence = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the creatures ranged defence stat? ");
                    int rangedDefence = Convert.ToInt32(Console.ReadLine());

                    enemies.Add(new Enemy(name, enemyDefenceLevel, stabDefence, slashDefence, crushDefence, magicDefence, rangedDefence));
                    File.WriteAllText(@"OSRSEnemies.json", JsonConvert.SerializeObject(enemies, Formatting.Indented));
                    Console.WriteLine("Enemy Saved! Press enter to continue!");
                    Console.ReadLine();
                }

                Console.Clear();
                Console.WriteLine("Time to choose your equipment!");

                //head items
                var headItems = GetItemsBySlot(EquipmentSlot.Head);
                int iterator = 1;
                foreach (var item in headItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("First select your helmet from the list above based on the associated number: ");
                int intSelection = Convert.ToInt32(Console.ReadLine());
                string headSelection = "";
                if (intSelection > 0 && intSelection <= headItems.Count)
                {
                    headSelection = headItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                //chest items
                var chestItems = GetItemsBySlot(EquipmentSlot.Chest);
                iterator = 1;
                foreach (var item in chestItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your chest item from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());

                string chestSelection = "";
                if (intSelection > 0 && intSelection <= chestItems.Count)
                {
                    chestSelection = chestItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                //Leg items
                var legItems = GetItemsBySlot(EquipmentSlot.Legs);
                iterator = 1;
                foreach (var item in legItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your chest item from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string legSelection = "";
                if (intSelection > 0 && intSelection <= legItems.Count)
                {
                    legSelection = legItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }

                Console.Clear();
                // Hand items
                var handItems = GetItemsBySlot(EquipmentSlot.Hands);
                iterator = 1;
                foreach (var item in handItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your gloves from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string handSelection = "";
                if (intSelection > 0 && intSelection <= handItems.Count)
                {
                    handSelection = handItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }

                Console.Clear();
                // Feet items
                var feetItems = GetItemsBySlot(EquipmentSlot.Feet);
                iterator = 1;
                foreach (var item in feetItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your boots from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string feetSelection = "";
                if (intSelection > 0 && intSelection <= feetItems.Count)
                {
                    feetSelection = feetItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                // Cape items
                var capeItems = GetItemsBySlot(EquipmentSlot.Cape);
                iterator = 1;
                foreach (var item in capeItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your cape from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string capeSelection = "";
                if (intSelection > 0 && intSelection <= capeItems.Count)
                {
                    capeSelection = capeItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                // Ring items
                var ringItems = GetItemsBySlot(EquipmentSlot.Ring);
                iterator = 1;
                foreach (var item in ringItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your ring from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string ringSelection = "";
                if (intSelection > 0 && intSelection <= ringItems.Count)
                {
                    ringSelection = ringItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                // Neck items
                var neckItems = GetItemsBySlot(EquipmentSlot.Neck);
                iterator = 1;
                foreach (var item in neckItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your amulet from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string neckSelection = "";
                if (intSelection > 0 && intSelection <= neckItems.Count)
                {
                    neckSelection = neckItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                // weapon items
                var weaponItems = GetItemsBySlot(EquipmentSlot.Weapon);
                iterator = 1;
                foreach (var item in weaponItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;

                }

                Console.Write("Next, select your weapon from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string weaponSelection = "";
                if (intSelection > 0 && intSelection <= weaponItems.Count)
                {
                    weaponSelection = weaponItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                // offHand items
                var offHandItems = GetItemsBySlot(EquipmentSlot.Offhand);
                iterator = 1;
                foreach (var item in offHandItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;
                }

                Console.Write("Next, select your offhand item from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string offHandSelection = "";
                if (intSelection > 0 && intSelection <= offHandItems.Count)
                {
                    offHandSelection = offHandItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }
                

                Console.Clear();
                // Ammunition/Bonus items
                var ammunitionItems = GetItemsBySlot(EquipmentSlot.Ammunition);
                iterator = 1;
                foreach (var item in ammunitionItems)
                {
                    Console.WriteLine($"{iterator}. \t{SplitCamelCase(item)}");
                    iterator++;
                }

                Console.Write("Next, select your ammunition or bonus item from the list above based on the associated number: ");
                intSelection = Convert.ToInt32(Console.ReadLine());
                string ammunitionSelection = "";
                if (intSelection > 0 && intSelection <= ammunitionItems.Count)
                {
                    ammunitionSelection = ammunitionItems[intSelection - 1];
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }

                string[] characters = new string[] { headSelection, chestSelection, legSelection, handSelection, feetSelection, neckSelection, ringSelection, neckSelection,
                weaponSelection, offHandSelection, ammunitionSelection  };

                Character.Character character = EquipmentFactory.Create(characters);

                character.AttackLevel = attackLevel;
                character.DefenceLevel = defenceLevel;
                character.StrengthLevel = strengthLevel;
                character.RangedLevel = rangedLevel;
                character.MagicLevel = magicLevel;
                character.PrayerLevel = prayerLevel;

                Console.Clear();
                Console.WriteLine("What is the weapons attack type associated with the attack style? ");
                Console.WriteLine("1. \tStab");
                Console.WriteLine("2. \tSlash");
                Console.WriteLine("3. \tCrush");
                int intWeaponAttackType = Convert.ToInt32(Console.ReadLine());
                int weaponAttackTypeBonus = 0;

                if (intWeaponAttackType == 1)
                {
                    weaponAttackTypeBonus = character.AttStab();
                    enemyDefenceBonus = enemies[selection].StabDefence;
                }
                else if (intWeaponAttackType == 2)
                {
                    weaponAttackTypeBonus = character.AttSlash();
                    enemyDefenceBonus = enemies[selection].SlashDefence;
                }
                else if (intWeaponAttackType == 3)
                {
                    weaponAttackTypeBonus = character.AttCrush();
                    enemyDefenceBonus = enemies[selection].CrushDefence;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }


                Console.Clear();
                Console.WriteLine("Select your current attack style by the number associated to it: ");
                Console.WriteLine("1. \tAccurate");
                Console.WriteLine("2. \tAggressive");
                Console.WriteLine("3. \tControlled");
                Console.WriteLine("4. \tDefensive");

                int attackStyle = Convert.ToInt32(Console.ReadLine());
                int selectedAttackStyleBonus = 0;
                int maxHit = 0;
                double toHit = 0.0;

                if (attackStyle == 1)
                {
                    selectedAttackStyleBonus = Calculations.AccurateAttackLevel(character.AttackLevel);
                    maxHit = Calculations.MaxHit(Calculations.AccurateOrDefensiveEffectiveStrength(character.StrengthLevel), character.MeleeStrength());
                    toHit = Calculations.ToHitCalculation(Calculations.AccurateAttackLevel(selectedAttackStyleBonus), weaponAttackTypeBonus);
                }
                else if (attackStyle == 2)
                {
                    selectedAttackStyleBonus = Calculations.DefensiveOrAggressiveAttackLevel(character.AttackLevel);
                    maxHit = Calculations.MaxHit(Calculations.AggressiveEffectiveStrength(character.StrengthLevel), character.MeleeStrength());
                    toHit = Calculations.ToHitCalculation(Calculations.AccurateAttackLevel(selectedAttackStyleBonus), weaponAttackTypeBonus);
                }
                else if (attackStyle == 3)
                {
                    selectedAttackStyleBonus = Calculations.ControlledAttackLevel(character.AttackLevel);
                    maxHit = Calculations.MaxHit(Calculations.ControlledEffectiveStrength(character.StrengthLevel), character.MeleeStrength());
                    toHit = Calculations.ToHitCalculation(Calculations.AccurateAttackLevel(selectedAttackStyleBonus), weaponAttackTypeBonus);
                }
                else if (attackStyle == 4)
                {
                    selectedAttackStyleBonus = Calculations.DefensiveOrAggressiveAttackLevel(character.AttackLevel);
                    maxHit = Calculations.MaxHit(Calculations.AccurateOrDefensiveEffectiveStrength(character.StrengthLevel), character.MeleeStrength());
                    toHit = Calculations.ToHitCalculation(Calculations.AccurateAttackLevel(selectedAttackStyleBonus), weaponAttackTypeBonus);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Exiting the program, press any button to continue");
                    Console.ReadLine();
                    break;
                }



                double enemyDefenceRoll = Calculations.EnemyDefenseRoll(enemyDefenceLevel, enemyDefenceBonus);
                double toHitProbability = Calculations.CompareCombatRolls(toHit, enemyDefenceRoll);

                toHitProbability = Math.Round(toHitProbability, 4) * 100;


                Console.WriteLine($"Your max hit is {maxHit}");
                Console.WriteLine($"With your chance to hit a {enemies[selection].Name} as {toHitProbability}%");
                break;
            }

            static string SplitCamelCase(string input) { return System.Text.RegularExpressions.Regex.Replace(input, "([A-Z])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim(); }
            List<string> GetItemsBySlot(EquipmentSlot equipmentSlot)
            {
                List<string> equipment = new List<string>();

                //checks the code for all classes with the equipment decorator type
                System.Reflection.Assembly assem = System.Reflection.Assembly.GetAssembly(typeof(EquipmentDecorator));
                //retrieves everything
                var types = assem.GetTypes()
                  //filters, produces an array with the results
                  .Where(t => String.Equals(t.Namespace, "OOPSemesterLongAssignment.Character", StringComparison.Ordinal)).ToArray();

                //looking for the derived class os equipment decorator
                foreach (Type tc in types)
                {
                    if (Type.GetType("OOPSemesterLongAssignment.Character." + tc.Name).BaseType == typeof(EquipmentDecorator))
                    {
                        //retrieving all the public/static fields
                        var itm = tc
                        .GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                        //filtering based on Type property
                          .Where(f => f.FieldType == typeof(EquipmentSlot)).ToArray();


                        //checking the value retrieved and compares it to the individual values in the enum
                        if (equipmentSlot == (EquipmentSlot)itm[0].GetValue(null))
                        {
                            equipment.Add(Convert.ToString(tc.Name));
                        }
                    }
                }
                return equipment;
            }
        }
    }
}
