using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: Heroes, IMagicCharacter
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
            : base(name)
        {
            this.Name = name;
            
            this.AddItem(new Staff());
        }
        
        public override int AttackValue
        {
            get
            {
                int value = 0;
                value += base.AttackValue;
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                value += base.DefenseValue;
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }

    }
}