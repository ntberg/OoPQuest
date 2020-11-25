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
        int isDead;
        Player MC = new Player();
        Enemy enemy = new Enemy();
        Encounter encounter = new Encounter();
        public Form1()
        {
            InitializeComponent();
            
            //init player
            MC.Name = "AAAA";
            playerNameBox.Text = MC.Name;
            MC.statHP = 35;
            MC.statAttack = 15;
            MC.statMP = 25;
            MC.curHP = MC.statHP;
            playerHPBox.Text = MC.curHP.ToString();
            
            //init enemy
            enemy.Name = "dummy";
            enemyNameBox.Text = enemy.Name;
            enemy.statHP = 25;
            enemy.statAttack = 10;
            enemy.curHP = enemy.statHP;
            enemyHPBox.Text = enemy.curHP.ToString();

            //init dummy arena
            Arena training = new Arena();
            training.Name = "Training Room";
            training.terrainID = 0;

            //Init first encounter and loop
            
            encounter.Player = MC;
            encounter.Enemy = enemy;
            encounter.Arena = training;
            outputBox.AppendText("Encounter started against " + encounter.Enemy.Name + "in arena " + encounter.Arena.Name + Environment.NewLine);
            outputBox.AppendText("The first turn is yours." + Environment.NewLine);








        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void attackButton_Click(object sender, EventArgs e)
        {
         
            encounter.Player.Attack(encounter.Player, encounter.Enemy);
            outputBox.AppendText(encounter.Player.Name + " attacked " + encounter.Enemy.Name + Environment.NewLine);
            enemyHPBox.Text = encounter.Enemy.curHP.ToString();
            encounter.runEnemyTurn(encounter.Player, encounter.Enemy);
            playerHPBox.Text = encounter.Player.curHP.ToString();
            isDead = encounter.checkHP(encounter.Player, encounter.Enemy);
            if(isDead == 1)
            {
                outputBox.AppendText("You died..." + Environment.NewLine);
            }
            else if(isDead == 2)
            {
                outputBox.AppendText("The enemy died!" + Environment.NewLine);
            }
            

                
            
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            //TODO: make this magic
            //encounter.Player.Attack(encounter.Player, encounter.Enemy);
            outputBox.AppendText(encounter.Player.Name + " used magic " +  Environment.NewLine);

            encounter.runEnemyTurn(encounter.Player, encounter.Enemy);
            playerHPBox.Text = encounter.Player.curHP.ToString();
            isDead = encounter.checkHP(encounter.Player, encounter.Enemy);
            if (isDead == 1)
            {
                outputBox.AppendText("You died..." + Environment.NewLine);
            }
            else if (isDead == 2)
            {
                outputBox.AppendText("The enemy died!" + Environment.NewLine);
            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
