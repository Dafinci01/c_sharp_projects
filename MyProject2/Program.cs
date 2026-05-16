using System;

namespace EnumPractice
{
    enum CharacterClass { Warrior = 1, Mage = 2, Rogue = 3, Paladin = 4, Archer = 5 }
    enum AccountType {Savings = 1, Current = 2, Corporate =3, Investment = 4, Offshore = 5}    
    [Flags]
    enum BankPermission { None = 0, ViewBalance = 1, Deposit = 2, Withdraw = 4, TransferFunds = 8, TakeLoan = 16, ManageCards =32, AdminOverride =}
    [Flags]
    enum AlertPreference{DNone = 0, SMS =1, Email = 4, PushNotification = 8, MonthlyStatement = 8}
    [Flags]
    enum Ability { None = 0, Stealth = 1, FireBlast = 2, ShieldBlock = 4, HealingAura = 8, PoisonArrow = 16, BattleCry = 32 }

    [Flags]
    enum Weaknesstype { None = 0, Fire = 1, Ice = 2, Poison = 4, Holy = 8 }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise_RPGCharacterClass();
            Exercise_SmartHomeAutomation();
            Exercise_UniversityCourseEnrollment();
            Exercise_HospitalStaffSystem();

        }
        // THIS FUNCTION ASSIGNS ABILITIES BASED ON CLASS
            string[] Classes = Enum.GetNames(typeof(CharacterClass));
                foreach(string className in Classes)
                {
                    Console.WriteLine(className);
                }
                string userInput = " ";
                if (Enum.TryParse(userInput, out CharacterClass cls) && Enum.IsDefined(typeof(CharacterClass), cls))
                {
                    int powerLevel =  (int)cls * 10;
                    Console.WriteLine($"{cls} - Power level: {powerLevel}");
                }
                else
                {
                    Console.WriteLine("Invalid Class");
                }
            static Ability GetAbilities(CharacterClass characterClass)
            {
                
                switch (characterClass)
                {
                    case CharacterClass.Mage:
                        return Ability.FireBlast | Ability.HealingAura;
                    case CharacterClass.Warrior:
                        return Ability.ShieldBlock | Ability.BattleCry;
                    case CharacterClass.Rogue:
                        return Ability.Stealth | Ability.PoisonArrow;
                    case CharacterClass.Paladin:
                        return Ability.HealingAura | Ability.ShieldBlock;
                    case CharacterClass.Archer:
                        return Ability.PoisonArrow | Ability.Stealth;
                    default:
                        return Ability.None;
                }
            }
            // THIS FUNCTION ASSIGNS WEAKNESS BASED ON CLASS
            static Weaknesstype GetWeakness(CharacterClass characterClass)
            {
                switch (characterClass)
                {
                    case CharacterClass.Mage:
                        return Weaknesstype.Ice | Weaknesstype.Holy;
                    case CharacterClass.Warrior:
                        return Weaknesstype.Fire | Weaknesstype.Poison;
                    case CharacterClass.Rogue:
                        return Weaknesstype.Holy | Weaknesstype.Fire;
                    case CharacterClass.Paladin:
                        return Weaknesstype.Poison | Weaknesstype.Ice;
                    case CharacterClass.Archer:
                        return Weaknesstype.Fire | Weaknesstype.Ice;
                    default:
                        return Weaknesstype.None;
                }
            }
            
            static void Exercise_RPGCharacterClass()
            {
            // CHARACTER ONE
            CharacterClass characterOneClass = CharacterClass.Mage;
            int characterOnePowerLevel = (int)characterOneClass * 10;
            Ability characterOneAbilities = GetAbilities(characterOneClass);
            Weaknesstype characterOneWeakness = GetWeakness(characterOneClass);

            Console.WriteLine($"CharacterOne is a {characterOneClass}");
            Console.WriteLine($"Power Level: {characterOnePowerLevel}");
            Console.WriteLine($"Abilities: {characterOneAbilities}");
            Console.WriteLine($"Weakness: {characterOneWeakness}");
            Console.WriteLine();

            // CHARACTER TWO
            CharacterClass characterTwoClass = CharacterClass.Warrior;
            int characterTwoPowerLevel = (int)characterTwoClass * 10;
            Ability characterTwoAbilities = GetAbilities(characterTwoClass);
            Weaknesstype characterTwoWeakness = GetWeakness(characterTwoClass);

            Console.WriteLine($"CharacterTwo is a {characterTwoClass}");
            Console.WriteLine($"Power Level: {characterTwoPowerLevel}");
            Console.WriteLine($"Abilities: {characterTwoAbilities}");
            Console.WriteLine($"Weakness: {characterTwoWeakness}");
            Console.WriteLine();

            // CHARACTER THREE
            CharacterClass characterThreeClass = CharacterClass.Rogue;
            int characterThreePowerLevel = (int)characterThreeClass * 10;
            Ability characterThreeAbilities = GetAbilities(characterThreeClass);
            Weaknesstype characterThreeWeakness = GetWeakness(characterThreeClass);

            Console.WriteLine($"CharacterThree is a {characterThreeClass}");
            Console.WriteLine($"Power Level: {characterThreePowerLevel}");
            Console.WriteLine($"Abilities: {characterThreeAbilities}");
            Console.WriteLine($"Weakness: {characterThreeWeakness}");
            Console.WriteLine();

            // CHARACTER FOUR
            CharacterClass characterFourClass = CharacterClass.Paladin;
            int characterFourPowerLevel = (int)characterFourClass * 10;
            Ability characterFourAbilities = GetAbilities(characterFourClass);
            Weaknesstype characterFourWeakness = GetWeakness(characterFourClass);

            Console.WriteLine($"CharacterFour is a {characterFourClass}");
            Console.WriteLine($"Power Level: {characterFourPowerLevel}");
            Console.WriteLine($"Abilities: {characterFourAbilities}");
            Console.WriteLine($"Weakness: {characterFourWeakness}");


        static void Exercise_SmartHomeAutomation(){
            AccountType Savings =
        }
        static void Exercise_UniversityCourseEnrollment(){

        }
        }
    }
}