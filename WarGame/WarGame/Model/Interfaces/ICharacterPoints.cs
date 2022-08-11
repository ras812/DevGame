using System;
namespace WarGame
{
	public interface ICharacterPoints
	{
		void IncreaseStrenght(int strenght);
		void DecreaseStrenght(int strenght);
		void IncreaseDexterity(int dexterity);
		void DecreaseDexterity(int dexterity);
		void IncreaseIntellegence(int intellegence);
		void DecreaseIntellegence(int intellegence);
	}
}

