using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Warrior : Character , IAttackable
    {
        public Warrior(string name, Faction faction) : base(name, health: 100, armor: 50, abilityPoints: 40, bag: new Satchel(), faction: faction)
        {

        }
        public void Attack(Character character)
        {

        }
    }
}
