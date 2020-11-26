using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OoPQuest
{
    public partial class Form1 : Form
    {
        bool chooseItem = true;
        int randEnemy;
        Player MC = new Player();
        Encounter encounter = new Encounter();

        //init possible professions
        Profession paladin = new Profession("Paladin", 40, 10, 15);
        Profession healer = new Profession("Priest", 25, 45, 5);
        Profession hero = new Profession("Wanderer", 35, 25, 10);
        Profession bard = new Profession("Bard", 30, 30, 5);

        //init possible arenas
        Arena training = new Arena("Training Room", 0);
        Arena dunes = new Arena("Sand Dunes", 1);
        Arena ice = new Arena("Frozen Sea", 2);
        Arena ocean = new Arena("Azure Waves", 3);
        Arena grass = new Arena("Moonlit Plains", 4);

        //init possible enemies
        Enemy dummy = new Enemy("Dummy", 25, 10, "I'm literally a punching bag...");
        Enemy sbeve = new Enemy("Pinecone Wyvern", 15, 15, "My name... wasn't Steve... ugh.");
        Enemy whale = new Enemy("Wide Whale", 50, 5, "CHANGE THE WORLD, MY FINAL MESSAGE. GOODBYE");
        Enemy olaf = new Enemy("Upset Snowman", 10, 25, "Can I at least get a warm hug before i go?");
        Enemy edge = new Enemy("Edgy Sword Boy", 35, 10, "Next time, I will defeat you!");




        public Form1()
        {
            InitializeComponent();
          
            







            //item/profession choice
            
            outputBox.AppendText("Choose your Profession using the buttons!" + Environment.NewLine);
            outputBox.AppendText("Attack: Paladin" + Environment.NewLine);
            outputBox.AppendText("Magic: Preist" + Environment.NewLine);
            outputBox.AppendText("Item: Wanderer" + Environment.NewLine);
            outputBox.AppendText("Defend: Bard" + Environment.NewLine);











        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (chooseItem == false)
            {

                encounter.Player.Attack(encounter.Player, encounter.Enemy, outputBox, enemyHPBox);
                encounter.checkHP(outputBox);

                if (encounter.Enemy.curHP > 0)
                {
                    encounter.Enemy.Attack(encounter.Enemy, encounter.Player, outputBox, playerHPBox);


                    encounter.Arena.envDoDamage(encounter.Player, encounter.Enemy, outputBox, playerHPBox, enemyHPBox);

                    encounter.checkHP(outputBox);
                }
            }
            else
            {
                //update player attributes
                MC.updateStats(paladin, playerNameBox, playerHPBox, playerMPBox);
                outputBox.AppendText("Great! Now press the start button to begin the adventure!" + Environment.NewLine);
                chooseItem = false;
            }
                
            
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            if (chooseItem == false)
            {

                encounter.Player.useMagic(outputBox, playerHPBox, playerMPBox);

                encounter.Enemy.Attack(encounter.Enemy, encounter.Player, outputBox, playerHPBox);
                encounter.checkHP(outputBox);
                if (encounter.Enemy.curHP > 0)
                {
                    encounter.Arena.envDoDamage(encounter.Player, encounter.Enemy, outputBox, playerHPBox, enemyHPBox);
                    encounter.checkHP(outputBox);
                }
            }
            else
            {
                //update player attributes
                MC.updateStats(healer, playerNameBox, playerHPBox, playerMPBox);
                outputBox.AppendText("Great! Now press the start button to begin the adventure!" + Environment.NewLine);
                chooseItem = false;
            }
           


        }

       


        private void startButton_Click(object sender, EventArgs e)
        {
            if (!chooseItem)
            {
                outputBox.Clear();
                playerHPBox.Text = MC.statHP.ToString();
                playerMPBox.Text = MC.statMP.ToString();
                
                Random rnd = new Random();
                randEnemy = rnd.Next(5);

                if (randEnemy == 0)
                {
                    encounter.startEncounter(MC, dummy, training, outputBox, enemyNameBox, enemyHPBox);
                }
                else if (randEnemy == 1)
                {
                    encounter.startEncounter(MC, sbeve, dunes, outputBox, enemyNameBox, enemyHPBox);
                }
                else if (randEnemy == 2)
                {
                    encounter.startEncounter(MC, olaf, ice, outputBox, enemyNameBox, enemyHPBox);
                }
                else if (randEnemy == 3)
                {
                    encounter.startEncounter(MC, whale, ocean, outputBox, enemyNameBox, enemyHPBox);
                }
                else if (randEnemy == 4)
                {
                    encounter.startEncounter(MC, edge, grass, outputBox, enemyNameBox, enemyHPBox);
                }

               
            }
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            if (chooseItem == false)
            {

                encounter.Player.useItem(outputBox, encounter.Enemy);

                encounter.Enemy.Attack(encounter.Enemy, encounter.Player, outputBox, playerHPBox);
                encounter.checkHP(outputBox);
                if (encounter.Enemy.curHP > 0)
                {
                    encounter.Arena.envDoDamage(encounter.Player, encounter.Enemy, outputBox, playerHPBox, enemyHPBox);
                    encounter.checkHP(outputBox);
                }
            }
            else
            {
                //update player attributes
                MC.updateStats(hero, playerNameBox, playerHPBox, playerMPBox);
                outputBox.AppendText("Great! Now press the start button to begin the adventure!" + Environment.NewLine);
                chooseItem = false;
            }
        }

        private void defendButton_Click(object sender, EventArgs e)
        {
            if (chooseItem == false)
            {

                encounter.Player.Defend(outputBox);


                encounter.Arena.envDoDamage(encounter.Player, encounter.Enemy, outputBox, playerHPBox, enemyHPBox);
                encounter.checkHP(outputBox);

            }
            else
            {
                //update player attributes
                MC.updateStats(bard, playerNameBox, playerHPBox, playerMPBox);
                outputBox.AppendText("Great! Now press the start button to begin the adventure!" + Environment.NewLine);
                chooseItem = false;
            }
        }
    }
}
