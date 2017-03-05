using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        public int HitPoints { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player(Game game, Point location)
            : base(game, location)
        {
            HitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 1))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom = null;
                }    
                if (inventory.Count == 1)
                    this.Equip(inventory[0].Name);
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (this.equippedWeapon != null)
            {
                if (equippedWeapon is IPotion)
                {
                    equippedWeapon.Attack(direction, random);
                    inventory.Remove(equippedWeapon);
                }
                else
                    equippedWeapon.Attack(direction, random);
            }
        }
    }
}
