using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeEngine;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private TicTacToe tic;

        public Form1()
        {
            InitializeComponent();
            this.tic = new TicTacToe();
            tic.Reset();

        }

        private void button_Click(Object sender, EventArgs e)
        {
            var button = sender as Button;
            int val = 0;

            if (Int32.TryParse(button.Text, out val))
            {
                
                tic.ChooseCell(val = val - 1);
                button.Text = tic.getACell(val).getText();

                if (tic.getStatus() == GameStatus.PlayerXWins)
                {
                    System.Windows.Forms.MessageBox.Show("Speler x wint!");
                    maakLeeg();
                    tic.Reset();
                }

                else if (tic.getStatus() == GameStatus.PlayerXPlays)
                {
                    System.Windows.Forms.MessageBox.Show("Speler x speelt!");
                
                }

                else if (tic.getStatus() == GameStatus.PlayerOPlays)
                {
                    System.Windows.Forms.MessageBox.Show("Speler o speelt!");
                  
                }


                else if (tic.getStatus() == GameStatus.PlayerOWins)
                {
                    System.Windows.Forms.MessageBox.Show("Speler o wint!");
                    maakLeeg();
                    tic.Reset();
                }

                else if (tic.getStatus() == GameStatus.PlayerXWins)
                {
                    System.Windows.Forms.MessageBox.Show("Speler x wint!");
                    maakLeeg();
                    tic.Reset();
                }

                else if (tic.getStatus() == GameStatus.Equal)
                {
                    System.Windows.Forms.MessageBox.Show("Gelijk spel!");
                    maakLeeg();
                    tic.Reset();
                }
  


            }

           else
            {
                System.Windows.Forms.MessageBox.Show("Geen geldige cell!");
            }
        }

        public void maakLeeg()
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
        
        }

    }
}
