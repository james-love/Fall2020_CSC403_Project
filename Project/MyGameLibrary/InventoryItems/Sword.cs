using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;
//using Fall2020_CSC403_Project.Properties;

namespace MyGameLibrary.InventoryObjects
{
    public class Sword : InventoryObject, IWeapon
    {
        private int damageAmount = 10;
        
        public Sword(Image img)
        {
            this.img = img;
        }
		
		public int GetDamage() {
			return damageAmount;
		}

        public override void Effect(BattleCharacter character)
        {
            throw new NotImplementedException();
        }

        public override void Effect(Player player)
        {
          player.EquippedWeapon = this;
        }
    }
}
