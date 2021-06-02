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
		//TODO: public string damage;
		public int damageDie;
		public int damageBonus;
		public int initiativeBonus;

		public Creature(string nameIn, int maxHPIn, int armorClassIn, int attackBonusIn, int damageDieIn, int damageBonusIn, int initiativeBonusIn)
		{
			name = nameIn;
			maxHP = maxHPIn;
			currentHP = maxHP;
			armorClass = armorClassIn;
			attackBonus = attackBonusIn;
			damageDie = damageDieIn;
			damageBonus = damageBonusIn;
			initiativeBonus = initiativeBonusIn;
		}
	}
}
