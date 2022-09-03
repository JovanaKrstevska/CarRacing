using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarRacing
{
    public partial class CarRacing : Form
    {

        int score;
        int carImage;
        int playerSpeed = 9;
        int trafficSpeed = 5;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public CarRacing()
        {
            InitializeComponent();
            ResetGame();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            txtScore.Text = "Score:" + score;
            score++;

            moveLine(5);
            if(goleft == true && PlayerCar.Left > 20)
            {
                PlayerCar.Left -= playerSpeed;
            }
            if(goright == true && PlayerCar.Left <400)
            {
                PlayerCar.Left += playerSpeed;
            }

            PinkCar.Top += trafficSpeed;
            GreenCar.Top += trafficSpeed;

            if(PinkCar.Top>530)
            {
                changeCars(PinkCar);
            }
            if(GreenCar.Top>530)
            {
                changeCars(GreenCar);
            }
            if(PlayerCar.Bounds.IntersectsWith(PinkCar.Bounds) || PlayerCar.Bounds.IntersectsWith(GreenCar.Bounds))
            {
                gameOver();
            }

            if(score>40 && score<300)
            {
                over.Image = Properties.Resources.gameover1;
            }
            if(score>300 && score<1500)
            {
                over.Image = Properties.Resources.gameover1;
                trafficSpeed = 12;
                playerSpeed = 10;
            }
            if(score>1500 && score<2500)
            {
                over.Image = Properties.Resources.gameover1;
                trafficSpeed = 15;
                playerSpeed = 13;
            }
            if(score>2500)
            {
                over.Image = Properties.Resources.gameover1;
                trafficSpeed = 17;
                playerSpeed = 15;
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
            carImage = rand.Next(1, 7);

            switch(carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(5, 200);
            }
            if((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 422);
            }

        }
        private void gameOver()
        {
            playSound();
            gameTimer.Stop();

            over.Visible = true;
            over.BringToFront();

            buttonStart.Enabled = true;
        }
        private void ResetGame()
        {
            buttonStart.Enabled = false;
            over.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            over.Image = Properties.Resources.gameover1;

            PinkCar.Top = carPosition.Next(300, 650) * -1;
            PinkCar.Left = carPosition.Next(5, 200);

            GreenCar.Top = carPosition.Next(100, 550) * -1;
            GreenCar.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void playSound()
        {
            SoundPlayer playcrash = new SoundPlayer(Properties.Resources.hit);
            playcrash.Play();
        }
    }
}
