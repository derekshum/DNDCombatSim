using System;

namespace DNDCombatSim
{
	public class Creature
	{
		public string name;
		public int maxHP;
		public int currentHP;
		public int armorClass;
		public int attackBonus;
		public string damage;
		public int initiativeBonus;

		public Creature(string nameIn, int maxHPIn, int armorClassIn, int attackBonusIn, string damageIn, int initiativeBonusIn)
		{
			name = nameIn;
			maxHP = maxHPIn;
			currentHP = maxHP;
			armorClass = armorClassIn;
			attackBonus = attackBonusIn;
			damage = damageIn;
			initiativeBonus = initiativeBonusIn;
		}
	}
}
