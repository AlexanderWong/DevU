using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HeroMonsterClassesChal
{
    public partial class Default : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Dice dice = new Dice();

            Character hero = new Character();
            hero.Name = "Link";
            hero.Health = 100;
            hero.DamageMaximum = 50;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Ganondorf";
            monster.Health = 150;
            monster.DamageMaximum = 30;
            monster.AttackBonus = true;


            if (hero.AttackBonus)
                monster.Defend(hero.Attack(dice));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(dice));
            
            while (hero.Health > 0  && monster.Health > 0)
            {
                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));

                results(hero);
                results(monster);
            }

            displayResults(hero, monster);

            /*
            int damage = hero.Attack(dice);
            monster.Defend(damage);

            damage = monster.Attack(dice);
            hero.Defend(damage);
            */
            

        }

        private void results(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - Damage Maximum : {2} - Attack Bonus: {3} </p>", character.Name, character.Health, character.DamageMaximum.ToString(), character.AttackBonus.ToString());
        }

        private void displayResults(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)          
                resultLabel.Text += String.Format("<p>There is no winner... both {0} and {1} were slain.</p>", opponent1.Name, opponent2.Name);
            if (opponent1.Health > 0 && opponent2.Health <= 0)
                resultLabel.Text += String.Format("<p>{0} is victorious and has slain {1}!</p>", opponent1.Name, opponent2.Name);
            if (opponent1.Health <= 0 && opponent2.Health > 0)
                resultLabel.Text += String.Format("<p>{0} has been defeated by the evil {1}.</p>", opponent1.Name, opponent2.Name);


            //resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - Damage Maximum : {2} - Attack Bonus: {3} </p>", character.Name, character.Health, character.DamageMaximum.ToString(), character.AttackBonus.ToString());                
        }


        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public bool AttackBonus { get; set; }


            public int Attack(Dice dice)
            {
                // Random random = new Random();
                // int damage = random.Next(this.DamageMaximum);
                dice.Sides = this.DamageMaximum;

                return dice.Roll();

            }

            public void Defend(int damage)
            {               
                this.Health -= damage;                
            }
        }

        class Dice
        {
            public int Sides { get; set; }

            Random random = new Random();

            public int Roll()
            {               
               return random.Next(this.Sides);              
            }
        }
    }
}