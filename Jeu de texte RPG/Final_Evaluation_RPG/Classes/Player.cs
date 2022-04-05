using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Evaluation_RPG.Classes
{
   
    public class Player : LivingEntity
    {
        private int xp;
        private int gp;
        private bool protect;
        private Monster enemy;
        private List<Power> myPowers;
        private Weapon myWeapon;

        public Player(string name, int hp) : base(name, hp)
        {
            this.xp = 0;
            this.gp = 0;
            this.protect = false;
            this.MyWeapon = GameFactory.CreateStick();
            this.MyPowers = new List<Power>();

        }

        public Player() : 
            base()
        {
        }

        public int Xp { get => xp; set => xp = value; }
        public int Gp { get => gp; set => gp = value; }
        public bool Protect { get => protect; set => protect = value; }
        public Monster Enemy { get => enemy; set => enemy = value; }
        public List<Power> MyPowers { get => myPowers; set => myPowers = value; }
        public Weapon MyWeapon { get => myWeapon; set => myWeapon = value; }
        public void Heal()
        {
            Console.WriteLine("Your hp is full now. ");
            this.Hp = 100;
        }

        public void Hide()
        {
            Console.WriteLine("You are hidden, now run! ");
            Enemy = null;
        }

        public void Sprinkle()
        {
            Console.WriteLine("You sprinkle the Sleepy Dust on the enemy!");
            if(enemy.Name == "Dragon")
            {
                Random rgp = new Random();
                int rpg = rgp.Next(1000, 10000);
                this.gp += rpg;
                Console.WriteLine("The dragon is asleep! Now go and run away! " + "\n You obtain: " + rpg + " gold.");
                Hide();
            }
            else
            {
                Console.WriteLine("You sprinkle the dust on the enemy! Run! ");
                Hide();
            }
        }

        public void AddPower(Power newPower)
        {
            this.myPowers.Add(newPower);
        }
        
        public Power GetPower(PowerType type)
        {
            for (int i = 0; i < this.myPowers.Count; i++)
            {
                Power obj = this.myPowers[i];
                if (obj.Type.Equals(type))
                {
                    this.myPowers.RemoveAt(i);
                    return obj;
                }
            }
            return null;
        }
        
        public void ApplyPower (PowerType type)
        {
            Power obj_power = this.GetPower(type);
            if (obj_power != null)
            {
                if (this.Xp >= obj_power.MinXp)
                {
                    switch (type)
                    {
                        case PowerType.Healing:
                            this.Heal();
                            break;
                        case PowerType.Invisible:
                            this.Hide();
                            break;
                        case PowerType.Protect:
                            this.Protect = true;
                            break;
                        case PowerType.Sleepy:
                            this.Sprinkle();
                            break;
                            
                    }
                }
                else
                {
                    Console.WriteLine("Player doesn't have enough experience point!");
                }
            }
            else
            {
                Console.WriteLine("Player doesn't have a power of that type!");
            }
        }

        public void UpdateWeapon (Weapon aWeapon)
        {
            if (this.myWeapon.MaxDamage < aWeapon.MaxDamage)
            {
                this.myWeapon = aWeapon;
            }
        }

        public void BuyItem(Item newItem)
        {
            if (this.Gp >= newItem.Price)
            {
                this.gp -= newItem.Price;
            }
            if (newItem is Weapon aWeapon)
            {
                if (this.myWeapon.MaxDamage < aWeapon.MaxDamage)
                {
                    if (this.myWeapon.MaxDamage < aWeapon.MaxDamage)
                    {
                        this.myWeapon = aWeapon;
                    }
                }
            }
            else if (newItem is Power newPower)
            {
                AddPower(newPower);
            }
        }

        //------------------------------------------------------------------------
        public int CountPower(PowerType type)
        {
            int counter = 0;

            foreach (Power obj in this.MyPowers)
            {
                if (obj.Type == type)
                {
                    counter++;
                }
            }
            return counter;
        }

        public override void ReceiveDamage(int damage)
        {
            if (this.protect)
            {
                this.Hp -= damage / 2;
            }
            else
            {
                this.Hp -= damage;
            }
            Console.WriteLine("You're hit! Your current HP = " + this.Hp);
        }
        public override void Attack()
        {
            Dice random = Dice.GetInstance();
            int min_damage = this.myWeapon.MinDamage;
            int max_damage = this.myWeapon.MaxDamage;
            int damage = random.Next(min_damage, max_damage);
            this.Enemy.ReceiveDamage(damage);

            if (Enemy.IsDead())
            {
                this.Xp += Enemy.Rxp;
                if (enemy.Name == "Dragon")
                {
                    Random rgp = new Random();
                    int rpg = rgp.Next(1000, 10000);
                    this.Gp += rpg;
                }
            }

        }
        //------------------------------------------------------------------------------
        public override string ToString()
        {
            string str = "Player : HP = " + base.Hp + " | XP = " + this.Xp + " | GP = " + this.Gp+"\n";
            str += "Weapon : " + myWeapon.Name +"\n" ;
            str += "Powers : Protect = " + CountPower(PowerType.Protect);
            str += " | Invisible = " + CountPower(PowerType.Invisible);
            str += " | Healing  = " + CountPower(PowerType.Healing);
            str += " | Sleepy  = " + CountPower(PowerType.Sleepy);

            return str;
        }
        
    }
}
