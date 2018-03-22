using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction) : base(name, health: 50, armor: 25, abilityPoints: 40, bag: new Backpack(), faction: faction)
        {

        }
        public void Heal(Character character)
        {

        }

        protected override double RestHealMultiplier => 0.5;
    }
}
