using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class DungeonMaster
    {
        public string JoinParty(string[] args)
        {
            var faction = args[0];
            var characterClass = args[1];
            var name = args[2];

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];

            return $"{itemName} added to pool.";

        }



        public string PickUpItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string UseItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string UseItemOn(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GiveCharacterItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GetStats()
        {
            throw new NotImplementedException();
        }

        public string Attack(string[] args)
        {
            throw new NotImplementedException();
        }

        public string Heal(string[] args)
        {
            throw new NotImplementedException();
        }

        public string EndTurn(string[] args)
        {
            throw new NotImplementedException();
        }

        public bool IsGameOver()
        {
            throw new NotImplementedException();
        }

    }
}
