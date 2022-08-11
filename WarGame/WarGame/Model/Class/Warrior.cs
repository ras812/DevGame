using System;
namespace WarGame
{
	public class Warrior : Human, IAttack, IDefend
	{
		public Warrior()
		{
		}

        void IAttack.Attack()
        {
            throw new NotImplementedException();
        }

        void IDefend.Defend()
        {
            throw new NotImplementedException();
        }
    }
}