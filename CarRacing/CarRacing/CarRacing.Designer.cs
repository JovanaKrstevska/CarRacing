
namespace CarRacing
{
    partial class CarRacing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.over = new System.Windows.Forms.PictureBox();
            this.PinkCar = new System.Windows.Forms.PictureBox();
            this.GreenCar = new System.Windows.Forms.PictureBox();
            this.PlayerCar = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.over)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.over);
            this.panel1.Controls.Add(this.PinkCar);
            this.panel1.Controls.Add(this.GreenCar);
            this.panel1.Controls.Add(this.PlayerCar);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 549);
            this.panel1.TabIndex = 0;
            // 
            // over
            // 
            this.over.Image = global::CarRacing.Properties.Resources.gameover1;
            this.over.Location = new System.Drawing.Point(112, 202);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(249, 129);
            this.over.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.over.TabIndex = 2;
            this.over.TabStop = false;
            // 
            // PinkCar
            // 
            this.PinkCar.Image = global::CarRacing.Properties.Resources.carPink;
            this.PinkCar.Location = new System.Drawing.Point(80, 83);
            this.PinkCar.Name = "PinkCar";
            this.PinkCar.Size = new System.Drawing.Size(50, 100);
            this.PinkCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PinkCar.TabIndex = 1;
            this.PinkCar.TabStop = false;
            this.PinkCar.Tag = "carLeft";
            // 
            // GreenCar
            // 
            this.GreenCar.Image = global::CarRacing.Properties.Resources.carGreen;
            this.GreenCar.Location = new System.Drawing.Point(337, 82);
            this.GreenCar.Name = "GreenCar";
            this.GreenCar.Size = new System.Drawing.Size(50, 101);
            this.GreenCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GreenCar.TabIndex = 1;
            this.GreenCar.TabStop = false;
            this.GreenCar.Tag = "carRight";
            // 
            // PlayerCar
            // 
            this.PlayerCar.Image = global::CarRacing.Properties.Resources.carOrange;
            this.PlayerCar.Location = new System.Drawing.Point(212, 431);
            this.PlayerCar.Name = "PlayerCar";
            this.PlayerCar.Size = new System.Drawing.Size(50, 100);
            this.PlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayerCar.TabIndex = 1;
            this.PlayerCar.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(463, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 549);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 549);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(230, 431);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 115);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(230, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 115);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(230, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 115);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(230, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(21, 596);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(140, 55);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Play Again";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(26, 654);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(180, 36);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 586);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 115);
            this.label2.TabIndex = 3;
            this.label2.Text = "Доколку дојдете до \'Game Over\' \r\nпритиснете на копчето \'Play Again\'\r\nза да играте" +
    " повторно";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // CarRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 736);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.Name = "CarRacing";
            this.Text = "CarRacing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.over)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinkCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox over;
        private System.Windows.Forms.PictureBox PinkCar;
        private System.Windows.Forms.PictureBox GreenCar;
        private System.Windows.Forms.PictureBox PlayerCar;
    }
}

