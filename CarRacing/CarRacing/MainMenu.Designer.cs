
namespace CarRacing
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CarRacing.Properties.Resources.picture_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.text);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 458);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::CarRacing.Properties.Resources.Controls;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(671, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 128);
            this.panel3.TabIndex = 2;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.Control;
            this.text.Location = new System.Drawing.Point(702, 246);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(152, 69);
            this.text.TabIndex = 1;
            this.text.Text = "Controls:";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CarRacing.Properties.Resources.Start_Button_Vector;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(33, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 68);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 456);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Panel panel3;
    }
}