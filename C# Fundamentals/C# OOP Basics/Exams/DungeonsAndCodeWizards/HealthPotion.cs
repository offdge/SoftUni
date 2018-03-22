using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class HealthPotion : Item
    {
        public HealthPotion() : base(5)
        {
        }

        public void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
            character.Health += 20;
        }
    }
}
