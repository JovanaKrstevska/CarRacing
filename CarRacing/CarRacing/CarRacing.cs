using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {

        int score;
        int carImage;
        int playerSpeed = 9;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            moveLine(5);
            if(goleft == true && PlayerCar.Left > 20)
            {
                PlayerCar.Left -= playerSpeed;
            }
            if(goright == true && PlayerCar.Left <400)
            {
                PlayerCar.Left += playerSpeed;
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void Key_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        void moveLine(int speed)
        {
            if(pictureBox1.Top>=500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }
        private void changeCars(PictureBox tempCar)
        {

        }
        private void gameOver()
        {

        }
        private void ResetGame()
        {
            buttonStart.Enabled = false;
            over.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            over.Image = Properties.Resources.gameover1;

            PinkCar.Top = carPosition.Next(200, 500) * -1;
            PinkCar.Left = carPosition.Next(5, 200);

            GreenCar.Top = carPosition.Next(200, 500) * -1;
            GreenCar.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }
        private void playSound()
        {

        }
    }
}
