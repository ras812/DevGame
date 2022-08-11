using System;
namespace WarGame
{
	public class Warrior : Human, IHealPoints
	{
        // Fields
        private readonly string _name;
        private readonly Gender _gender;
        private int _hp;
        private int _strength;
        private int _dexterity;
        private int _intellegence;
        private Weapon _weapon;
        private Armor _armor;

        // Properties
        public override string Name { get { return _name; } }
        public override Gender HumanGender { get { return _gender; } }
        public override int HP { get { return _hp; } }
        public override int Strenght { get { return _strength; } }
        public override int Dexterity { get { return _dexterity; } }
        public override int Intellegence { get { return _intellegence; } }

        // Properties (Obj)
        public Weapon EquippedWeapon { get { return _weapon; } }
        public Armor EquippedArmor { get { return _armor; } }

        // Constructors
        public Warrior() : this("UnNamedPlayer", Gender.Male, 100, 5, 5, 5,
                                new Weapon("Kriss", ItemType.Light, 3, 7),
                                new Armor("Jacket", ItemType.Light, 5))
        { }

        public Warrior(string name, Gender gender, int hp, int strenght,
                       int dexterity, int intelligence, Weapon weapon, Armor armor)
        {
            _name = name;
            _gender = gender;
            _hp = hp;
            _strength = strenght;
            _dexterity = dexterity;
            _intellegence = intelligence;
            _weapon = weapon;
            _armor = armor;
        }

        public void DecreaseHP(int damage)
        {
            _hp = _hp - damage;
        }

        public void IncreaseHP(int healing)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine(String.Join("\n", "\nClass: " + GetType(), "Name: " + Name,
                              "Gender: " + HumanGender, "HP: " + HP, "Strenght: " + Strenght,
                              "Dexterity: " + Dexterity, "Intellegence: " + Intellegence,
                              "Weapon: " + EquippedWeapon.Name,
                              "Armor: " + EquippedArmor.Name));
        }
    }
}